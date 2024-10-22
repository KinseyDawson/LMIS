using DawsonErp;
using LMIS.Modules.ReaderManage.CardLevel;
using LMIS.Modules.ReaderManage.LibraryCard;
using LMIS.Modules.ReaderManage.UserBill;
using MyRequest = Serenity.Services.SaveRequest<LMIS.ReaderManage.LibraryCardRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.ReaderManage.LibraryCardRow;

namespace LMIS.ReaderManage;

public interface ILibraryCardSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class LibraryCardSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILibraryCardSaveHandler
{
    public LibraryCardSaveHandler(IRequestContext context)
            : base(context)
    {

    }
    protected override void ValidateRequest()
    {
        if (IsCreate)
        {
            var exist = LibraryCardHelper.QueryByUserId(Connection, Request.Entity.UserId ?? 0, LibraryCardStatusEnum.Normal);
            if (exist != null)
            {
                throw new ValidationError(Texts.Validation.LibraryCardUniqueError.ToString(Localizer));
            }
            exist = LibraryCardHelper.QueryByUserId(Connection, Request.Entity.UserId ?? 0, LibraryCardStatusEnum.Lose);
            if (exist != null&&exist.LevelId!=Request.Entity.LevelId)//补卡必须等级一致
            {
                throw new ValidationError(Texts.Validation.MakeUpLibraryCardLevelError.ToString(Localizer));
            }

            Row.LibraryCardNo = SerialNumberHelper.GenerateWithYitter();
            Row.Status = (int)LibraryCardStatusEnum.Normal;
            Row.CreateTime = DateTime.Now;
        }
        else
        {
            if (Old.Status == (int)LibraryCardStatusEnum.Lose)
            {
                throw new ValidationError(Texts.Validation.LibraryCardOperateIllegalityError.ToString(Localizer));
            }
        }
        Row.UpdateTime = DateTime.Now;
        base.ValidateRequest();
    }
    protected override void AfterSave()
    {
        if (IsCreate)
        {
            var exist = LibraryCardHelper.QueryByUserId(Connection, Request.Entity.UserId ?? 0, LibraryCardStatusEnum.Lose);
            if (exist == null)//办卡,补卡没有费用
            {
                var cardLevelRow = CardLevelHelper.QueryByCardLevelId(Connection, Request.Entity.LevelId ?? 0);
                UserBillHelper.Insert(Connection,
                    Request.Entity.UserId ?? 0,
                    BillTypeEnum.Card,
                    cardLevelRow.Fee ?? 0,
                    $"办卡:{Row.LibraryCardNo}");
            }
        }
        else
        {
            if (Old.Status != Request.Entity.Status && Old.LevelId != Request.Entity.LevelId)
            {
                throw new ValidationError(Texts.Validation.LibraryCardOperateIllegalityError.ToString(Localizer));
            }
            else//借阅卡升级
            {
                if (Old.LevelId != Request.Entity.LevelId)
                {
                    var oldLevelRow = CardLevelHelper.QueryByCardLevelId(Connection, Old.LevelId ?? 0);
                    var newLevelRow = CardLevelHelper.QueryByCardLevelId(Connection, Request.Entity.LevelId ?? 0);
                    if (oldLevelRow.Fee > newLevelRow.Fee)
                    {
                        throw new ValidationError(Texts.Validation.LibraryCardUniqueError.ToString(Localizer));
                    }
                    var fee = (newLevelRow.Fee ?? 0) - (oldLevelRow.Fee ?? 0);
                    UserBillHelper.Insert(Connection,
                        Old.UserId ?? 0,
                        BillTypeEnum.CardUpLevel,
                        fee,
                        $"升级:{Row.LibraryCardNo}");
                }
            }
        }
        base.AfterSave();
    }
}
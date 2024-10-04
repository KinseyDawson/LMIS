using DawsonErp;
using LMIS.Modules.ReaderManage.CardLevel;
using LMIS.Modules.ReaderManage.UserBill;
using MySql.Data.MySqlClient;
using Serenity.Services;
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
    protected override void ExecuteSave()
    {
        try
        {
            base.ExecuteSave();
        }
        catch (MySqlException ex) when (ex.Message.StartsWith("duplicate", StringComparison.OrdinalIgnoreCase))
        {
            throw new ValidationError(Texts.Validation.LibraryCardUniqueError.ToString(Localizer));
        }
    }
    protected override void ValidateRequest()
    {
        if (IsCreate)
        {
            Row.LibraryCardNo = SerialNumberHelper.GenerateWithYitter();
            Row.CreateTime = DateTime.Now;
        }
        Row.UpdateTime = DateTime.Now;
        base.ValidateRequest();
    }
    protected override void AfterSave()
    {
        if (IsCreate)//办卡
        {
            var cardLevelRow = CardLevelHelper.QueryByCardLevelId(Connection,
            Request.Entity.LevelId ?? 0);
            CardBillHelper.Insert(Connection,
                Request.Entity.UserId ?? 0,
                BillTypeEnum.Card,
                cardLevelRow.Fee ?? 0,
                $"办卡:{Row.LibraryCardNo}");
        }
        base.AfterSave();
    }
}
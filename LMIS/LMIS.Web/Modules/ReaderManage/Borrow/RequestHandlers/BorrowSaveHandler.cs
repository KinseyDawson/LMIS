using DawsonErp;
using LMIS.Modules.BookManage.Book;
using LMIS.Modules.ReaderManage.Borrow;
using LMIS.Modules.ReaderManage.CardLevel;
using LMIS.Modules.ReaderManage.LibraryCard;
using MyRequest = Serenity.Services.SaveRequest<LMIS.ReaderManage.BorrowRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.ReaderManage.BorrowRow;

namespace LMIS.ReaderManage;

public interface IBorrowSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class BorrowSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBorrowSaveHandler
{
    public BorrowSaveHandler(IRequestContext context)
            : base(context)
    {
    }
    protected override void ValidateRequest()
    {
        if (IsCreate)
        {
            var cardRow = LibraryCardHelper.QueryByUserId(Connection, Request.Entity.UserId ?? 0, LibraryCardStatusEnum.Normal);
            if (cardRow == null)
            {
                throw new ValidationError(Texts.Validation.BookUnborrowableEoor.ToString(Localizer));
            }
            var cardLevelRow = CardLevelHelper.QueryByCardLevelId(Connection, cardRow.LevelId ?? 0);
            var existBorrowCount = BorrowHelper.QueryBorrowedCount(Connection,Request.Entity.UserId??0);
            if (existBorrowCount >= cardLevelRow.BorrowBooks)
            {
                throw new ValidationError(Texts.Validation.BorrowedCountExceedError.ToString(Localizer));
            }
            var bookRow = BookHelper.QueryByBookId(Connection, Request.Entity.BookId ?? 0);
            if (bookRow == null || bookRow.BookStatus != (int)BookStatusEnum.Borrowable)
            {
                throw new ValidationError(Texts.Validation.BookUnborrowableEoor.ToString(Localizer));
            }
            if (bookRow.BorrowableInventory < 1)
            {
                throw new ValidationError(Texts.Validation.BookHasNotEnoughInventoryError.ToString(Localizer));
            }
            Row.BorrowNo = $"BW{SerialNumberHelper.GenerateWithYitter()}";
            Row.BorrowStatus = (int)BorrowStatusEnum.Borrowed;
            Row.BorrowDate = DateTime.Today;
            Row.BorrowReturnDate = DateTime.Today.AddDays(cardLevelRow.BorrowDays ?? 0);
            Row.CreateTime = DateTime.Now;
        }
        Row.UpdateTime = DateTime.Now;
        base.ValidateRequest();
    }
    protected override void AfterSave()
    {
        if (IsCreate)
        {
            //借书，可借数量自减1
            BookHelper.DncreaseBorrowableInventory(Connection, Request.Entity.BookId ?? 0, 1);
        }
        base.AfterSave();
    }
}
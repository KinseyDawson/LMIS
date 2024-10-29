using LMIS.Modules.BookManage.Book;
using LMIS.Modules.BookManage.Bookshelf;
using LMIS.Modules.InventoryManage.BookStore;
using LMIS.Modules.ReaderManage.Borrow;
using LMIS.Modules.ReaderManage.CardLevel;
using LMIS.Modules.ReaderManage.LibraryCard;
using LMIS.Modules.ReaderManage.UserBill;
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
            var existBorrowBookCount = BorrowHelper.QueryNotReturned(Connection, Request.Entity.UserId ?? 0, Request.Entity.BookId ?? 0);
            if (existBorrowBookCount > 0)
            {
                throw new ValidationError(Texts.Validation.BorrowRepeatlyError.ToString(Localizer));
            }
            var cardRow = LibraryCardHelper.QueryByUserId(Connection, Request.Entity.UserId ?? 0, LibraryCardStatusEnum.Normal);
            if (cardRow == null)
            {
                throw new ValidationError(Texts.Validation.BookUnborrowableEoor.ToString(Localizer));
            }
            var cardLevelRow = CardLevelHelper.QueryByCardLevelId(Connection, cardRow.LevelId ?? 0);
            var existBorrowCount = BorrowHelper.QueryBorrowedCount(Connection, Request.Entity.UserId ?? 0);
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
            var bookStoreRow = BookStoreHelper.QueryByBookIdAndBookshelfId(Connection, Request.Entity.BookId ?? 0, Request.Entity.BookshelfId ?? 0);
            if (bookStoreRow == null || bookStoreRow.Inventory < 1)
            {
                throw new ValidationError(Texts.Validation.NotBookOnTheBookshelfError.ToString(Localizer));
            }
            Row.BorrowNo = $"BW{SerialNumberHelper.GenerateWithYitter()}";
            Row.BorrowStatus = (int)BorrowStatusEnum.Borrowed;
            Row.BorrowDate = DateTime.Today;
            Row.BorrowReturnDate = DateTime.Today.AddDays(cardLevelRow.BorrowDays ?? 0);
            Row.CreateTime = DateTime.Now;
        }
        else
        {
            if (Old.BorrowStatus != (int)BorrowStatusEnum.Borrowed)
            {
                throw new ValidationError(Texts.Validation.BorrowOperateIllegalityError.ToString(Localizer));
            }
            else if (Request.Entity.BorrowStatus == (int)BorrowStatusEnum.Borrowed)
            {
                throw new ValidationError(Texts.Validation.BorrowOperateIllegalityError.ToString(Localizer));
            }
            else if (Request.Entity.BorrowStatus == (int)BorrowStatusEnum.Returned)
            {
                if (DateTime.Today > Old.BorrowReturnDate)
                {
                    throw new ValidationError(Texts.Validation.BorrowExpiredError.ToString(Localizer));
                }
            }
            else if (Request.Entity.BorrowStatus == (int)BorrowStatusEnum.ExpiredAndReturned)
            {
                if (DateTime.Today <= Old.BorrowReturnDate)
                {
                    throw new ValidationError(Texts.Validation.BorrowNotExpiredError.ToString(Localizer));
                }
            }
            var cardRow = LibraryCardHelper.QueryByUserId(Connection, Old.UserId ?? 0, LibraryCardStatusEnum.Normal);
            if (cardRow == null)
            {
                throw new ValidationError(Texts.Validation.LibraryCardInvalidError.ToString(Localizer));
            }
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
        else
        {
            var cardRow = LibraryCardHelper.QueryByUserId(Connection, Old.UserId ?? 0, LibraryCardStatusEnum.Normal);
            var cardLevelRow = CardLevelHelper.QueryByCardLevelId(Connection, cardRow.LevelId ?? 0);
            if (Request.Entity.BorrowStatus == (int)BorrowStatusEnum.Damaged)//损坏
            {
                var bookRow = BookHelper.QueryByBookId(Connection, Old.BookId ?? 0);
                BookHelper.DecreaseStockInventory(Connection, Old.BookId ?? 0, 1);//扣除库存
                UserBillHelper.Insert(Connection, Old.UserId ?? 0,
                    BillTypeEnum.BookRent,
                    cardLevelRow.Rent ?? 0, $"还书-借阅单号:{Old.BorrowNo}");
                UserBillHelper.Insert(Connection, Old.UserId ?? 0,
                    BillTypeEnum.BookCompensation,
                    bookRow.Price ?? 0, $"书籍损坏-借阅单号:{Old.BorrowNo}");
                BookshelfHelper.Down(Connection, Old.BookshelfId ?? 0, 1);//扣除书架书籍数量
                BookStoreHelper.Decrease(Connection, Old.BookId ?? 0, Old.BookshelfId ?? 0, 1);//扣除书籍收录数量
            }
            else if (Request.Entity.BorrowStatus == (int)BorrowStatusEnum.Returned)//正常归还恢复可借用数量
            {
                BookHelper.IncreaseBorrowableInventory(Connection, Old.BookId ?? 0, 1);
                UserBillHelper.Insert(Connection, Old.UserId ?? 0,
                    BillTypeEnum.BookRent,
                    (cardLevelRow.Rent * cardLevelRow.Discount) ?? 0, $"还书-借阅单号:{Old.BorrowNo}");
            }
            else if (Request.Entity.BorrowStatus == (int)BorrowStatusEnum.ExpiredAndReturned)//过期归还恢复可借用数量
            {
                BookHelper.IncreaseBorrowableInventory(Connection, Old.BookId ?? 0, 1);
                UserBillHelper.Insert(Connection, Old.UserId ?? 0,
                    BillTypeEnum.BookRent,
                    cardLevelRow.Rent ?? 0, $"还书-借阅单号:{Old.BorrowNo}");
                var days = (DateTime.Today - Old.BorrowReturnDate).Value.Days;
                UserBillHelper.Insert(Connection, Old.UserId ?? 0,
                    BillTypeEnum.ExpireedPenalty,
                    (cardLevelRow.Penalty * days) ?? 0, $"过期罚金-借阅单号:{Old.BorrowNo}");
            }
        }
        base.AfterSave();
    }
}
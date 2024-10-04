using LMIS.Modules.BookManage.Book;
using LMIS.Modules.BookManage.Bookshelf;
using LMIS.Modules.InventoryManage.BookStore;
using MyRequest = Serenity.Services.SaveRequest<LMIS.InventoryManage.DownBookshelfRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.InventoryManage.DownBookshelfRow;

namespace LMIS.InventoryManage;

public interface IDownBookshelfSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class DownBookshelfSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IDownBookshelfSaveHandler
{
    private readonly IUserRetrieveService _userRetrieveService;
    public DownBookshelfSaveHandler(IRequestContext context, IUserRetrieveService userRetrieveService)
            : base(context)
    {
        _userRetrieveService = userRetrieveService;
    }
    protected override void ValidateRequest()
    {
        if (IsCreate)
        {
            var userId = _userRetrieveService.ByUsername(User.Identity?.Name ?? throw new InvalidOperationException()).Id;
            Row.CreateTime = DateTime.Now;
            Row.UpdateTime = DateTime.Now;
            Row.OperateUserId = int.Parse(userId);
        }
        var bookRow = BookHelper.QueryByBookId(Connection, Request.Entity.BookId ?? 0);
        var bookStoreRow = BookStoreHelper.QueryByBookIdAndBookshelfId(Connection,
            Request.Entity.BookId ?? 0,
            Request.Entity.BookshelfId ?? 0);
        if (bookStoreRow == null || bookStoreRow.Inventory < Request.Entity.Inventory)
        {
            throw new ValidationError(Texts.Validation.BookStoreHasNotEnoughInventory.ToString(Localizer));
        }
        if (bookRow == null || bookRow.BorrowableInventory < Request.Entity.Inventory)
        {
            throw new ValidationError(Texts.Validation.BookStoreHasNotEnoughInventory.ToString(Localizer));
        }
        base.ValidateRequest();
    }
    protected override void AfterSave()
    {
        BookHelper.DncreaseInventory(Connection,
            Request.Entity.BookId ?? 0,
            Request.Entity.Inventory ?? 0);
        BookStoreHelper.Decrease(Connection,
            Request.Entity.BookId ?? 0,
            Request.Entity.BookshelfId ?? 0,
            Request.Entity.Inventory ?? 0);
        BookshelfHelper.Down(Connection,
            Request.Entity.BookshelfId ?? 0,
            Request.Entity.Inventory ?? 0);
        base.AfterSave();
    }
}
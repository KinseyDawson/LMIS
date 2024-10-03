using LMIS.Modules.BookManage.Book;
using LMIS.Modules.BookManage.Bookshelf;
using LMIS.Modules.InventoryManage.BookStore;
using OfficeOpenXml.FormulaParsing.Utilities;
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.InventoryManage.UpBookshelfRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.InventoryManage.UpBookshelfRow;

namespace LMIS.InventoryManage;

public interface IUpBookshelfSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class UpBookshelfSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IUpBookshelfSaveHandler
{
    private readonly IUserRetrieveService _userRetrieveService;
    public UpBookshelfSaveHandler(IRequestContext context, IUserRetrieveService userRetrieveService)
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
        var bookshelfRow = BookshelfHelper.QueryById(Connection, Request.Entity.BookshelfId ?? 0);
        if (bookshelfRow.BookCapacity < bookshelfRow.BookCount + Request.Entity.Inventory)
        {
            throw new ValidationError(Texts.Validation.BookshlefExceedCapacity.ToString(Localizer));
        }
        base.ValidateRequest();
    }
    protected override void AfterSave()
    {
        BookHelper.IncreaseInventory(Connection,
            Request.Entity.BookId ?? 0,
            Request.Entity.Inventory ?? 0);
        BookshelfHelper.Up(Connection,
            Request.Entity.BookshelfId ?? 0,
            Request.Entity.Inventory ?? 0);
        var bookStoreRow = BookStoreHelper.QueryByBookIdAndBookshelfId(Connection,
            Request.Entity.BookId ?? 0,
            Request.Entity.BookshelfId ?? 0);
        if (bookStoreRow == null)
        {
            BookStoreHelper.Insert(Connection,
                Request.Entity.BookId ?? 0,
                Request.Entity.BookshelfId ?? 0,
                Request.Entity.Inventory ?? 0);
        }
        else
        {
            BookStoreHelper.Increase(Connection,
                Request.Entity.BookId ?? 0,
                Request.Entity.BookshelfId ?? 0,
                Request.Entity.Inventory ?? 0);
        }
        base.AfterSave();
    }
}
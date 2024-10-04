using LMIS.Modules.BookManage.Book;
using MySql.Data.MySqlClient;
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.BookManage.BookRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.BookManage.BookRow;

namespace LMIS.BookManage;

public interface IBookSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class BookSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBookSaveHandler
{
    public BookSaveHandler(IRequestContext context)
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
            throw new ValidationError(Texts.Validation.BookUniqueError.ToString(Localizer));
        }
    }
    protected override void ValidateRequest()
    {
        if (IsCreate)
        {
            Row.CreateTime = DateTime.Now;
            Row.Inventory = 0;
            Row.BorrowableInventory = 0;
            Row.BookStatus = 1;
        }
        Row.UpdateTime = DateTime.Now;
        base.ValidateRequest();
    }
}
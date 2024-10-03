using MySql.Data.MySqlClient;
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.BookManage.BookshelfRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.BookManage.BookshelfRow;

namespace LMIS.BookManage;

public interface IBookshelfSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class BookshelfSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBookshelfSaveHandler
{
    public BookshelfSaveHandler(IRequestContext context)
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
            throw new ValidationError(Texts.Validation.BookshelfUniqueError.ToString(Localizer));
        }
    }
    protected override void ValidateRequest()
    {
        if (IsCreate)
        {
            Row.CreateTime = DateTime.Now;
        }
        Row.UpdateTime = DateTime.Now;
        base.ValidateRequest();
    }
}
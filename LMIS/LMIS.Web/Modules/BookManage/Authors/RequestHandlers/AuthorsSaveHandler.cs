using MySql.Data.MySqlClient;
using MyRequest = Serenity.Services.SaveRequest<LMIS.BookManage.AuthorsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.BookManage.AuthorsRow;

namespace LMIS.BookManage;

public interface IAuthorsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class AuthorsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAuthorsSaveHandler
{
    public AuthorsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
    protected override void ExecuteSave()
    {
        try
        {
            base.ExecuteSave();
        }
        catch (MySqlException ex) when (ex.Message.StartsWith("Duplicate"))
        {
            throw new ValidationError(Texts.Validation.AuthorUniqueError.ToString(Localizer));
        }
    }
    protected override void ValidateRequest()
    {
        if (IsCreate)
        {
            Row.CreateTime = DateTime.Now;
            Row.UpdateTime = DateTime.Now;
        }
        else
        {
            Row.UpdateTime = DateTime.Now;
        }
        base.ValidateRequest();
    }
}
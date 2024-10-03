using MySql.Data.MySqlClient;
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.BookManage.AuthorRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.BookManage.AuthorRow;

namespace LMIS.BookManage;

public interface IAuthorSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class AuthorSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAuthorSaveHandler
{
    public AuthorSaveHandler(IRequestContext context)
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
            throw new ValidationError(Texts.Validation.AuthorUniqueError.ToString(Localizer));
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
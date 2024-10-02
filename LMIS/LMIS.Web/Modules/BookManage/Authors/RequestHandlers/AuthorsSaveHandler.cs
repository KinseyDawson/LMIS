using Serenity.Services;
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
}
using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.BookManage.AuthorRow;

namespace LMIS.BookManage;

public interface IAuthorDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class AuthorDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAuthorDeleteHandler
{
    public AuthorDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
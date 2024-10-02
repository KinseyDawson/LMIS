using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.BookManage.AuthorsRow;

namespace LMIS.BookManage;

public interface IAuthorsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class AuthorsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAuthorsDeleteHandler
{
    public AuthorsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
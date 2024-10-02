using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.BookManage.AuthorsRow>;
using MyRow = LMIS.BookManage.AuthorsRow;

namespace LMIS.BookManage;

public interface IAuthorsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class AuthorsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAuthorsListHandler
{
    public AuthorsListHandler(IRequestContext context)
            : base(context)
    {
    }
}
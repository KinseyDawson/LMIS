using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.BookManage.AuthorRow>;
using MyRow = LMIS.BookManage.AuthorRow;

namespace LMIS.BookManage;

public interface IAuthorListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class AuthorListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAuthorListHandler
{
    public AuthorListHandler(IRequestContext context)
            : base(context)
    {
    }
}
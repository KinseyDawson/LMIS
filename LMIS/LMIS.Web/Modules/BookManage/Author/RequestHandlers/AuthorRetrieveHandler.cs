using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.BookManage.AuthorRow>;
using MyRow = LMIS.BookManage.AuthorRow;

namespace LMIS.BookManage;

public interface IAuthorRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class AuthorRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAuthorRetrieveHandler
{
    public AuthorRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
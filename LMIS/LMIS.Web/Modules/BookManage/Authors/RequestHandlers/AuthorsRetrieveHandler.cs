using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.BookManage.AuthorsRow>;
using MyRow = LMIS.BookManage.AuthorsRow;

namespace LMIS.BookManage;

public interface IAuthorsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class AuthorsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAuthorsRetrieveHandler
{
    public AuthorsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
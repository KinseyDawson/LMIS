using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.BookManage.BooksRow>;
using MyRow = LMIS.BookManage.BooksRow;

namespace LMIS.BookManage;

public interface IBooksRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class BooksRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBooksRetrieveHandler
{
    public BooksRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
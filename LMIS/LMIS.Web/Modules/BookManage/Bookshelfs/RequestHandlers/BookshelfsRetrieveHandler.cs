using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.BookManage.BookshelfsRow>;
using MyRow = LMIS.BookManage.BookshelfsRow;

namespace LMIS.BookManage;

public interface IBookshelfsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class BookshelfsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBookshelfsRetrieveHandler
{
    public BookshelfsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
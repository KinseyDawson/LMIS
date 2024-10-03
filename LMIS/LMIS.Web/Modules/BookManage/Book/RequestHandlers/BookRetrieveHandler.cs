using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.BookManage.BookRow>;
using MyRow = LMIS.BookManage.BookRow;

namespace LMIS.BookManage;

public interface IBookRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class BookRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBookRetrieveHandler
{
    public BookRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
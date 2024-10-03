using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.BookManage.BookshelfRow>;
using MyRow = LMIS.BookManage.BookshelfRow;

namespace LMIS.BookManage;

public interface IBookshelfRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class BookshelfRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBookshelfRetrieveHandler
{
    public BookshelfRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
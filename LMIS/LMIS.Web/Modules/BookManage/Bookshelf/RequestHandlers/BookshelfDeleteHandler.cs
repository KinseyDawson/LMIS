using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.BookManage.BookshelfRow;

namespace LMIS.BookManage;

public interface IBookshelfDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class BookshelfDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IBookshelfDeleteHandler
{
    public BookshelfDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
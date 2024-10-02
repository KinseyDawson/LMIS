using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.BookManage.BooksRow;

namespace LMIS.BookManage;

public interface IBooksDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class BooksDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IBooksDeleteHandler
{
    public BooksDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
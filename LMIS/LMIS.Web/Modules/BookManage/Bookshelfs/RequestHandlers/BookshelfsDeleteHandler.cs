using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.BookManage.BookshelfsRow;

namespace LMIS.BookManage;

public interface IBookshelfsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class BookshelfsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IBookshelfsDeleteHandler
{
    public BookshelfsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
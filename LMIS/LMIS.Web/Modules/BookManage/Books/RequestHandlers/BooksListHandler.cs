using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.BookManage.BooksRow>;
using MyRow = LMIS.BookManage.BooksRow;

namespace LMIS.BookManage;

public interface IBooksListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class BooksListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBooksListHandler
{
    public BooksListHandler(IRequestContext context)
            : base(context)
    {
    }
}
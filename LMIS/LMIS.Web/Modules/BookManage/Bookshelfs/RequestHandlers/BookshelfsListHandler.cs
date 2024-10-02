using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.BookManage.BookshelfsRow>;
using MyRow = LMIS.BookManage.BookshelfsRow;

namespace LMIS.BookManage;

public interface IBookshelfsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class BookshelfsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBookshelfsListHandler
{
    public BookshelfsListHandler(IRequestContext context)
            : base(context)
    {
    }
}
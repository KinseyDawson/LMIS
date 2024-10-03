using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.BookManage.BookshelfRow>;
using MyRow = LMIS.BookManage.BookshelfRow;

namespace LMIS.BookManage;

public interface IBookshelfListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class BookshelfListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBookshelfListHandler
{
    public BookshelfListHandler(IRequestContext context)
            : base(context)
    {
    }
}
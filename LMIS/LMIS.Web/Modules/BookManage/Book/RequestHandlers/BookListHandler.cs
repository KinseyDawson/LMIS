using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.BookManage.BookRow>;
using MyRow = LMIS.BookManage.BookRow;

namespace LMIS.BookManage;

public interface IBookListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class BookListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBookListHandler
{
    public BookListHandler(IRequestContext context)
            : base(context)
    {
    }
}
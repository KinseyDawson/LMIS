using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.BookManage.BookshelfsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.BookManage.BookshelfsRow;

namespace LMIS.BookManage;

public interface IBookshelfsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class BookshelfsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBookshelfsSaveHandler
{
    public BookshelfsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.BookManage.BooksRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.BookManage.BooksRow;

namespace LMIS.BookManage;

public interface IBooksSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class BooksSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBooksSaveHandler
{
    public BooksSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
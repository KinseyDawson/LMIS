using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.BookManage.BookRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.BookManage.BookRow;

namespace LMIS.BookManage;

public interface IBookSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class BookSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBookSaveHandler
{
    public BookSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
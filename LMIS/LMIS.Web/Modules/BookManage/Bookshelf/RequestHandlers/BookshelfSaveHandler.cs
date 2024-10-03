using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.BookManage.BookshelfRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.BookManage.BookshelfRow;

namespace LMIS.BookManage;

public interface IBookshelfSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class BookshelfSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBookshelfSaveHandler
{
    public BookshelfSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
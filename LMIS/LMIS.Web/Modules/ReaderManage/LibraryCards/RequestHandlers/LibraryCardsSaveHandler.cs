using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.ReaderManage.LibraryCardsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.ReaderManage.LibraryCardsRow;

namespace LMIS.ReaderManage;

public interface ILibraryCardsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class LibraryCardsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILibraryCardsSaveHandler
{
    public LibraryCardsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
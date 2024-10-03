using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.ReaderManage.LibraryCardRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.ReaderManage.LibraryCardRow;

namespace LMIS.ReaderManage;

public interface ILibraryCardSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class LibraryCardSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILibraryCardSaveHandler
{
    public LibraryCardSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
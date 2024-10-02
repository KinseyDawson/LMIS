using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.ReaderManage.LibraryCardLoseRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.ReaderManage.LibraryCardLoseRow;

namespace LMIS.ReaderManage;

public interface ILibraryCardLoseSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class LibraryCardLoseSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILibraryCardLoseSaveHandler
{
    public LibraryCardLoseSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.ReaderManage.LibraryCardLoseRow>;
using MyRow = LMIS.ReaderManage.LibraryCardLoseRow;

namespace LMIS.ReaderManage;

public interface ILibraryCardLoseRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class LibraryCardLoseRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILibraryCardLoseRetrieveHandler
{
    public LibraryCardLoseRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
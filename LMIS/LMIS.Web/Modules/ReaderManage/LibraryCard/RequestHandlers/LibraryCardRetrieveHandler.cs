using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.ReaderManage.LibraryCardRow>;
using MyRow = LMIS.ReaderManage.LibraryCardRow;

namespace LMIS.ReaderManage;

public interface ILibraryCardRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class LibraryCardRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILibraryCardRetrieveHandler
{
    public LibraryCardRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
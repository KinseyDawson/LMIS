using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.ReaderManage.LibraryCardsRow>;
using MyRow = LMIS.ReaderManage.LibraryCardsRow;

namespace LMIS.ReaderManage;

public interface ILibraryCardsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class LibraryCardsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILibraryCardsRetrieveHandler
{
    public LibraryCardsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.ReaderManage.LibraryCardLoseRow;

namespace LMIS.ReaderManage;

public interface ILibraryCardLoseDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class LibraryCardLoseDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ILibraryCardLoseDeleteHandler
{
    public LibraryCardLoseDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
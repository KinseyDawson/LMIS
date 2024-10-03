using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.ReaderManage.LibraryCardRow;

namespace LMIS.ReaderManage;

public interface ILibraryCardDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class LibraryCardDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ILibraryCardDeleteHandler
{
    public LibraryCardDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
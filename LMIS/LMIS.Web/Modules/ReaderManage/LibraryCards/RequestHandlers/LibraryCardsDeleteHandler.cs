using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.ReaderManage.LibraryCardsRow;

namespace LMIS.ReaderManage;

public interface ILibraryCardsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class LibraryCardsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ILibraryCardsDeleteHandler
{
    public LibraryCardsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
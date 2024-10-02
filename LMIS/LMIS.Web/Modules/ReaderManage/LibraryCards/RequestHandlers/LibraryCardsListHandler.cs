using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.ReaderManage.LibraryCardsRow>;
using MyRow = LMIS.ReaderManage.LibraryCardsRow;

namespace LMIS.ReaderManage;

public interface ILibraryCardsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class LibraryCardsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILibraryCardsListHandler
{
    public LibraryCardsListHandler(IRequestContext context)
            : base(context)
    {
    }
}
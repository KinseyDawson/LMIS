using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.ReaderManage.LibraryCardLoseRow>;
using MyRow = LMIS.ReaderManage.LibraryCardLoseRow;

namespace LMIS.ReaderManage;

public interface ILibraryCardLoseListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class LibraryCardLoseListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILibraryCardLoseListHandler
{
    public LibraryCardLoseListHandler(IRequestContext context)
            : base(context)
    {
    }
}
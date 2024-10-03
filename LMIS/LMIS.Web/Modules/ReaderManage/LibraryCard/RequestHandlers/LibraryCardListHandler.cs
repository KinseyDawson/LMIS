using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.ReaderManage.LibraryCardRow>;
using MyRow = LMIS.ReaderManage.LibraryCardRow;

namespace LMIS.ReaderManage;

public interface ILibraryCardListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class LibraryCardListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILibraryCardListHandler
{
    public LibraryCardListHandler(IRequestContext context)
            : base(context)
    {
    }
}
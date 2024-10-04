using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.ReaderManage.BorrowRow>;
using MyRow = LMIS.ReaderManage.BorrowRow;

namespace LMIS.ReaderManage;

public interface IBorrowListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class BorrowListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBorrowListHandler
{
    public BorrowListHandler(IRequestContext context)
            : base(context)
    {
    }
}
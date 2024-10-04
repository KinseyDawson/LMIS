using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.ReaderManage.BorrowRow>;
using MyRow = LMIS.ReaderManage.BorrowRow;

namespace LMIS.ReaderManage;

public interface IBorrowRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class BorrowRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBorrowRetrieveHandler
{
    public BorrowRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
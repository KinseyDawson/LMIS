using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.InventoryManage.DownBookshelfRow>;
using MyRow = LMIS.InventoryManage.DownBookshelfRow;

namespace LMIS.InventoryManage;

public interface IDownBookshelfRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class DownBookshelfRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IDownBookshelfRetrieveHandler
{
    public DownBookshelfRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
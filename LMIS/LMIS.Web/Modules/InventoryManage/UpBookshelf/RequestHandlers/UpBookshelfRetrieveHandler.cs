using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.InventoryManage.UpBookshelfRow>;
using MyRow = LMIS.InventoryManage.UpBookshelfRow;

namespace LMIS.InventoryManage;

public interface IUpBookshelfRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class UpBookshelfRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IUpBookshelfRetrieveHandler
{
    public UpBookshelfRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
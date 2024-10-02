using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.InventoryManage.UpBookshelfsRow>;
using MyRow = LMIS.InventoryManage.UpBookshelfsRow;

namespace LMIS.InventoryManage;

public interface IUpBookshelfsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class UpBookshelfsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IUpBookshelfsRetrieveHandler
{
    public UpBookshelfsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
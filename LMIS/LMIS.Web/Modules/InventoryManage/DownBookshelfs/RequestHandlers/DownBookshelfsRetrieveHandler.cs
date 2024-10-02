using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.InventoryManage.DownBookshelfsRow>;
using MyRow = LMIS.InventoryManage.DownBookshelfsRow;

namespace LMIS.InventoryManage;

public interface IDownBookshelfsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class DownBookshelfsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IDownBookshelfsRetrieveHandler
{
    public DownBookshelfsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
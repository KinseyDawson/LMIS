using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.InventoryManage.DownBookshelfRow>;
using MyRow = LMIS.InventoryManage.DownBookshelfRow;

namespace LMIS.InventoryManage;

public interface IDownBookshelfListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class DownBookshelfListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IDownBookshelfListHandler
{
    public DownBookshelfListHandler(IRequestContext context)
            : base(context)
    {
    }
}
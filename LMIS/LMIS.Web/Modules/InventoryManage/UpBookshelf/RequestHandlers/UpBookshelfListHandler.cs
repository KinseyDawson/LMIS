using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.InventoryManage.UpBookshelfRow>;
using MyRow = LMIS.InventoryManage.UpBookshelfRow;

namespace LMIS.InventoryManage;

public interface IUpBookshelfListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UpBookshelfListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUpBookshelfListHandler
{
    public UpBookshelfListHandler(IRequestContext context)
            : base(context)
    {
    }
}
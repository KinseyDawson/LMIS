using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.InventoryManage.DownBookshelfsRow>;
using MyRow = LMIS.InventoryManage.DownBookshelfsRow;

namespace LMIS.InventoryManage;

public interface IDownBookshelfsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class DownBookshelfsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IDownBookshelfsListHandler
{
    public DownBookshelfsListHandler(IRequestContext context)
            : base(context)
    {
    }
}
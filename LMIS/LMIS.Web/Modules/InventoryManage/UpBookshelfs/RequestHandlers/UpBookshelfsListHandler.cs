using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.InventoryManage.UpBookshelfsRow>;
using MyRow = LMIS.InventoryManage.UpBookshelfsRow;

namespace LMIS.InventoryManage;

public interface IUpBookshelfsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UpBookshelfsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUpBookshelfsListHandler
{
    public UpBookshelfsListHandler(IRequestContext context)
            : base(context)
    {
    }
}
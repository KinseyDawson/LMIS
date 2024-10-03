using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.InventoryManage.UpBookshelfRow;

namespace LMIS.InventoryManage;

public interface IUpBookshelfDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class UpBookshelfDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IUpBookshelfDeleteHandler
{
    public UpBookshelfDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.InventoryManage.DownBookshelfRow;

namespace LMIS.InventoryManage;

public interface IDownBookshelfDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class DownBookshelfDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IDownBookshelfDeleteHandler
{
    public DownBookshelfDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
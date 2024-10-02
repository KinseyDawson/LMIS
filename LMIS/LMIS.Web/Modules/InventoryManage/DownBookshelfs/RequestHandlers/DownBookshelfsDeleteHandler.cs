using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.InventoryManage.DownBookshelfsRow;

namespace LMIS.InventoryManage;

public interface IDownBookshelfsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class DownBookshelfsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IDownBookshelfsDeleteHandler
{
    public DownBookshelfsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.InventoryManage.UpBookshelfsRow;

namespace LMIS.InventoryManage;

public interface IUpBookshelfsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class UpBookshelfsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IUpBookshelfsDeleteHandler
{
    public UpBookshelfsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
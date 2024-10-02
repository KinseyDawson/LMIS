using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.InventoryManage.UpBookshelfsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.InventoryManage.UpBookshelfsRow;

namespace LMIS.InventoryManage;

public interface IUpBookshelfsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class UpBookshelfsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IUpBookshelfsSaveHandler
{
    public UpBookshelfsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
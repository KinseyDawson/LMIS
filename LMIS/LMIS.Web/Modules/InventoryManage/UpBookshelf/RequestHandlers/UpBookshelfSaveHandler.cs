using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.InventoryManage.UpBookshelfRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.InventoryManage.UpBookshelfRow;

namespace LMIS.InventoryManage;

public interface IUpBookshelfSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class UpBookshelfSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IUpBookshelfSaveHandler
{
    public UpBookshelfSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.InventoryManage.DownBookshelfRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.InventoryManage.DownBookshelfRow;

namespace LMIS.InventoryManage;

public interface IDownBookshelfSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class DownBookshelfSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IDownBookshelfSaveHandler
{
    public DownBookshelfSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.InventoryManage.DownBookshelfsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.InventoryManage.DownBookshelfsRow;

namespace LMIS.InventoryManage;

public interface IDownBookshelfsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class DownBookshelfsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IDownBookshelfsSaveHandler
{
    public DownBookshelfsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
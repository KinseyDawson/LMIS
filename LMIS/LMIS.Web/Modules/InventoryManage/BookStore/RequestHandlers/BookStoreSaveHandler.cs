using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.InventoryManage.BookStoreRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.InventoryManage.BookStoreRow;

namespace LMIS.InventoryManage;

public interface IBookStoreSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class BookStoreSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBookStoreSaveHandler
{
    public BookStoreSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
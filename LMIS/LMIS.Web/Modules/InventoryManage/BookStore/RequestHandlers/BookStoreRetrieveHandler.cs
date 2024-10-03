using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.InventoryManage.BookStoreRow>;
using MyRow = LMIS.InventoryManage.BookStoreRow;

namespace LMIS.InventoryManage;

public interface IBookStoreRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class BookStoreRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBookStoreRetrieveHandler
{
    public BookStoreRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
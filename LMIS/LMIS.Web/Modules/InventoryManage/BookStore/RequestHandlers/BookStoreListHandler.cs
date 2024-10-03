using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.InventoryManage.BookStoreRow>;
using MyRow = LMIS.InventoryManage.BookStoreRow;

namespace LMIS.InventoryManage;

public interface IBookStoreListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class BookStoreListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBookStoreListHandler
{
    public BookStoreListHandler(IRequestContext context)
            : base(context)
    {
    }
}
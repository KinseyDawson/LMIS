using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.InventoryManage.BookStoreRow;

namespace LMIS.InventoryManage;

public interface IBookStoreDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class BookStoreDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IBookStoreDeleteHandler
{
    public BookStoreDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
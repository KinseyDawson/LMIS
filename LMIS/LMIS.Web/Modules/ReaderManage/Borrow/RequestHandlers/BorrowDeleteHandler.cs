using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.ReaderManage.BorrowRow;

namespace LMIS.ReaderManage;

public interface IBorrowDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class BorrowDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IBorrowDeleteHandler
{
    public BorrowDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.ReaderManage.UserBillRow;

namespace LMIS.ReaderManage;

public interface IUserBillDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class UserBillDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IUserBillDeleteHandler
{
    public UserBillDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
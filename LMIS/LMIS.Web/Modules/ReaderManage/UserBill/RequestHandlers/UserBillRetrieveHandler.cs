using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.ReaderManage.UserBillRow>;
using MyRow = LMIS.ReaderManage.UserBillRow;

namespace LMIS.ReaderManage;

public interface IUserBillRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class UserBillRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IUserBillRetrieveHandler
{
    public UserBillRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
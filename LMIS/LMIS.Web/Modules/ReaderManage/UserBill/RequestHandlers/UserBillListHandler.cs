using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.ReaderManage.UserBillRow>;
using MyRow = LMIS.ReaderManage.UserBillRow;

namespace LMIS.ReaderManage;

public interface IUserBillListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserBillListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserBillListHandler
{
    public UserBillListHandler(IRequestContext context)
            : base(context)
    {
    }
}
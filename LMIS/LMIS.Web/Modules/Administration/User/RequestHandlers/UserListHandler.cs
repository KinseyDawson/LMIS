using MyRequest = LMIS.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.Administration.UserRow>;
using MyRow = LMIS.Administration.UserRow;

namespace LMIS.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}
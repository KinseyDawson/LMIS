using LMIS.Administration;
using LMIS.Modules.Common.Constants;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.ReaderManage.UserBillRow>;
using MyRow = LMIS.ReaderManage.UserBillRow;

namespace LMIS.ReaderManage;

public interface IUserBillListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserBillListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserBillListHandler
{
    private readonly IUserRetrieveService _retrieveService;
    public UserBillListHandler(IRequestContext context, IUserRetrieveService userRetrieveService)
            : base(context)
    {
        _retrieveService = userRetrieveService;
    }
    protected override void ApplyFilters(SqlQuery query)
    {
        base.ApplyFilters(query);
        if (User.Identity?.Name == Constants.ADMIN)
        {
            return;
        }
        var userRow = _retrieveService.ByUsername(User.Identity?.Name ?? throw new InvalidOperationException());
        var roleRows = RoleHelper.GetRoles(Connection, Convert.ToInt32(userRow.Id));
        if (roleRows != null && roleRows.Any(u => u.RoleName == "运营"))
        {
            return;
        }
        var filter = new Criteria(MyRow.Fields.UserId) == userRow.Id;
        query.Where(filter);
    }
}
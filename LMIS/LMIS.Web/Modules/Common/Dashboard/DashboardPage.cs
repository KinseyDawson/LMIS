
using LMIS.Administration;
using LMIS.Modules.Common.Constants;
using LMIS.Modules.ReaderManage.Borrow;
using LMIS.Modules.ReaderManage.UserBill;
using LMIS.ReaderManage;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace LMIS.Common.Pages;

[Route("Dashboard/[action]")]
public class DashboardPage : Controller
{
    private static List<string> BackgroundColors = ["rgba(255, 99, 132, 0.2)",
                                    "rgba(255, 159, 64, 0.2)",
                                    "rgba(255, 205, 86, 0.2)",
                                    "rgba(75, 192, 192, 0.2)",
                                    "rgba(54, 162, 235, 0.2)"];
    private static List<string> BorderColors = ["rgb(255, 99, 132)",
                                    "rgb(255, 159, 64)",
                                    "rgb(255, 205, 86)",
                                    "rgb(75, 192, 192)",
                                    "rgb(54, 162, 235)"];
    [PageAuthorize, HttpGet, Route("~/")]
    public ActionResult Index([FromServices] ITwoLevelCache cache,
        [FromServices] IUserRetrieveService retrieveService,
        [FromServices] ISqlConnections sqlConnections)
    {
        if (cache is null)
            throw new System.ArgumentNullException(nameof(cache));

        if (sqlConnections is null)
            throw new System.ArgumentNullException(nameof(sqlConnections));

        var o = BorrowRow.Fields;
        var borrowedCriteria = (o.BorrowStatus == (int)BorrowStatusEnum.Borrowed) && (o.BorrowReturnDate >= DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss"));
        var expiredAndBorrowedCriteria = (o.BorrowStatus == (int)BorrowStatusEnum.Borrowed) && (o.BorrowReturnDate < DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss"));
        var returnedCriteria = (o.BorrowStatus == (int)BorrowStatusEnum.Returned) || (o.BorrowStatus == (int)BorrowStatusEnum.ExpiredAndReturned);
        var damageCriteria = (o.BorrowStatus == (int)BorrowStatusEnum.Damaged);
        var cachedModel = cache.GetLocalStoreOnly($"{User.Identity?.Name}DashboardPageModel", TimeSpan.FromMinutes(5),
                    o.GenerationKey, () =>
                    {
                        var model = new DashboardPageModel();
                        using (var connection = sqlConnections.NewFor<BorrowRow>())
                        {
                            var isNormal = JugeIsNormal(User, retrieveService, connection);
                            if (isNormal.Item1)
                            {
                                borrowedCriteria = borrowedCriteria && o.UserId == isNormal.Item2;
                                expiredAndBorrowedCriteria = expiredAndBorrowedCriteria && o.UserId == isNormal.Item2;
                                returnedCriteria = returnedCriteria && o.UserId == isNormal.Item2;
                                damageCriteria = damageCriteria && o.UserId == isNormal.Item2;
                            }
                            model.BorrowedCount = connection.Count<BorrowRow>(borrowedCriteria);
                            model.ExpiredAndBorrowedCount = connection.Count<BorrowRow>(expiredAndBorrowedCriteria);
                            model.ReturnedCount = connection.Count<BorrowRow>(returnedCriteria);
                            model.DamageCount = connection.Count<BorrowRow>(damageCriteria);
                            model.BorrowType = CalculateBorrowType(connection, isNormal);
                            model.BillType = CalculateBillType(connection, isNormal);
                        }
                        return model;
                    });
        return View(MVC.Views.Common.Dashboard.DashboardIndex, cachedModel);
    }
    private (bool, string) JugeIsNormal(ClaimsPrincipal user,
        IUserRetrieveService retrieveService,
        IDbConnection connection)
    {
        if (User.Identity?.Name == Constants.ADMIN)
        {
            return (false, null);
        }
        var userRow = retrieveService.ByUsername(User.Identity?.Name ?? throw new InvalidOperationException());
        var roleRows = RoleHelper.GetRoles(connection, Convert.ToInt32(userRow.Id));
        if (roleRows != null && roleRows.Any(u => u.RoleName == "运营"))
        {
            return (false, null);
        }
        return (true, userRow.Id);
    }
    private ChartStatistics CalculateBorrowType(IDbConnection connection, (bool, string) isNormal)
    {
        var sqlText = @"select 
	                        c.CategoryName
                        from
	                        borrows a
                        left join bookshelfs b on
	                        (a.BookshelfId = b.BookshelfId)
                        left join categories c on
	                        (b.CategoryId = c.CategoryId)";
        if (isNormal.Item1)
        {
            sqlText = $"{sqlText} where a.UserId ='{isNormal.Item2}'";
        }
        var rowDatas = connection.Query<string>(sqlText);
        if (rowDatas.IsNullOrEmpty())
        {
            return ChartStatistics.Empty;
        }
        var r = new ChartStatistics()
        {
            BackgroundColors = new List<string>(),
            BorderColors = new List<string>(),
            Datas = new List<decimal>(),
            Labels = new List<string>(),
        };
        var index = 0;
        foreach (var group in rowDatas.GroupBy(u => u))
        {
            r.Labels.Add(group.Key);
            r.Datas.Add(group.Count());
            r.BackgroundColors.Add(BackgroundColors[index % BackgroundColors.Count]);
            r.BorderColors.Add(BorderColors[index % BackgroundColors.Count]);
            index++;
        }
        return r;
    }

    private ChartStatistics CalculateBillType(IDbConnection connection, (bool, string) isNormal)
    {
        var sqlText = @"select * from userbills ";
        if (isNormal.Item1)
        {
            sqlText = $"{sqlText} where UserId ='{isNormal.Item2}'";
        }
        var rowDatas = connection.Query<UserBillRow>(sqlText);
        if (rowDatas.IsNullOrEmpty())
        {
            return ChartStatistics.Empty;
        }
        var r = new ChartStatistics()
        {
            BackgroundColors = new List<string>(),
            BorderColors = new List<string>(),
            Datas = new List<decimal>(),
            Labels = new List<string>(),
        };
        var index = 0;
        foreach (var group in rowDatas.GroupBy(u => u.Type))
        {
            r.Labels.Add(((BillTypeEnum)group.Key).GetDescription());
            r.Datas.Add(group.Sum(i => i.Fee ?? 0));
            r.BackgroundColors.Add(BackgroundColors[index % BackgroundColors.Count]);
            r.BorderColors.Add(BorderColors[index % BackgroundColors.Count]);
            index++;
        }
        return r;
    }
}

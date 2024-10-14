
using LMIS.Modules.ReaderManage.Borrow;
using LMIS.ReaderManage;

namespace LMIS.Common.Pages;

[Route("Dashboard/[action]")]
public class DashboardPage : Controller
{
    [PageAuthorize, HttpGet, Route("~/")]
    public ActionResult Index([FromServices] ITwoLevelCache cache, [FromServices] ISqlConnections sqlConnections)
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
        var cachedModel = cache.GetLocalStoreOnly("DashboardPageModel", TimeSpan.FromMinutes(5),
                    o.GenerationKey, () =>
                    {
                        var model = new DashboardPageModel();
                        using (var connection = sqlConnections.NewFor<BorrowRow>())
                        {
                            //model.BorrowedCount = connection.Count<BorrowRow>(borrowedCriteria);
                            //model.ExpiredAndBorrowedCount = connection.Count<BorrowRow>(expiredAndBorrowedCriteria);
                            //model.ReturnedCount = connection.Count<BorrowRow>(returnedCriteria);
                            //model.DamageCount = connection.Count<BorrowRow>(damageCriteria);
                            model.BorrowedCount = 4;
                            model.ExpiredAndBorrowedCount = 3;
                            model.ReturnedCount = 5;
                            model.DamageCount = 1;
                        }
                        return model;
                    });
        return View(MVC.Views.Common.Dashboard.DashboardIndex, cachedModel);
    }
}

using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.ReaderManage.Pages;

[PageAuthorize(typeof(UserBillRow))]
public class UserBillPage : Controller
{
    [Route("ReaderManage/UserBill")]
    public ActionResult Index()
    {
        return this.GridPage("@/ReaderManage/UserBill/UserBillPage",
            UserBillRow.Fields.PageTitle());
    }
}
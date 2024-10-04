using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.ReaderManage.Pages;

[PageAuthorize(typeof(BorrowRow))]
public class BorrowPage : Controller
{
    [Route("ReaderManage/Borrow")]
    public ActionResult Index()
    {
        return this.GridPage("@/ReaderManage/Borrow/BorrowPage",
            BorrowRow.Fields.PageTitle());
    }
}
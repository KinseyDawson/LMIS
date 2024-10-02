using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.InventoryManage.Pages;

[PageAuthorize(typeof(UpBookshelfsRow))]
public class UpBookshelfsPage : Controller
{
    [Route("InventoryManage/UpBookshelfs")]
    public ActionResult Index()
    {
        return this.GridPage("@/InventoryManage/UpBookshelfs/UpBookshelfsPage",
            UpBookshelfsRow.Fields.PageTitle());
    }
}
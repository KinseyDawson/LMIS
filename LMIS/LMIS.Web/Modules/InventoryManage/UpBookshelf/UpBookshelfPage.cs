using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.InventoryManage.Pages;

[PageAuthorize(typeof(UpBookshelfRow))]
public class UpBookshelfPage : Controller
{
    [Route("InventoryManage/UpBookshelf")]
    public ActionResult Index()
    {
        return this.GridPage("@/InventoryManage/UpBookshelf/UpBookshelfPage",
            UpBookshelfRow.Fields.PageTitle());
    }
}
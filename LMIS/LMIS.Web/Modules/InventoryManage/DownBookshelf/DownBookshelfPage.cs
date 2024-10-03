using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.InventoryManage.Pages;

[PageAuthorize(typeof(DownBookshelfRow))]
public class DownBookshelfPage : Controller
{
    [Route("InventoryManage/DownBookshelf")]
    public ActionResult Index()
    {
        return this.GridPage("@/InventoryManage/DownBookshelf/DownBookshelfPage",
            DownBookshelfRow.Fields.PageTitle());
    }
}
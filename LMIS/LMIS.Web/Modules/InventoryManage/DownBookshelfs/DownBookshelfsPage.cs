using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.InventoryManage.Pages;

[PageAuthorize(typeof(DownBookshelfsRow))]
public class DownBookshelfsPage : Controller
{
    [Route("InventoryManage/DownBookshelfs")]
    public ActionResult Index()
    {
        return this.GridPage("@/InventoryManage/DownBookshelfs/DownBookshelfsPage",
            DownBookshelfsRow.Fields.PageTitle());
    }
}
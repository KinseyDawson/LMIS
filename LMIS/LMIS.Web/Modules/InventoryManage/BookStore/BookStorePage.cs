using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.InventoryManage.Pages;

[PageAuthorize(typeof(BookStoreRow))]
public class BookStorePage : Controller
{
    [Route("InventoryManage/BookStore")]
    public ActionResult Index()
    {
        return this.GridPage("@/InventoryManage/BookStore/BookStorePage",
            BookStoreRow.Fields.PageTitle());
    }
}
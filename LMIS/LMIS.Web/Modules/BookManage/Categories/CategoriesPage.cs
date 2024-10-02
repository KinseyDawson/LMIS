using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.BookManage.Pages;

[PageAuthorize(typeof(CategoriesRow))]
public class CategoriesPage : Controller
{
    [Route("BookManage/Categories")]
    public ActionResult Index()
    {
        return this.GridPage("@/BookManage/Categories/CategoriesPage",
            CategoriesRow.Fields.PageTitle());
    }
}
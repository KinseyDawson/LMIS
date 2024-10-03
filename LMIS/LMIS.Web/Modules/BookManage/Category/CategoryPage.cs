using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.BookManage.Pages;

[PageAuthorize(typeof(CategoryRow))]
public class CategoryPage : Controller
{
    [Route("BookManage/Category")]
    public ActionResult Index()
    {
        return this.GridPage("@/BookManage/Category/CategoryPage",
            CategoryRow.Fields.PageTitle());
    }
}
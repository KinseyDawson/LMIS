using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.BookManage.Pages;

[PageAuthorize(typeof(BooksRow))]
public class BooksPage : Controller
{
    [Route("BookManage/Books")]
    public ActionResult Index()
    {
        return this.GridPage("@/BookManage/Books/BooksPage",
            BooksRow.Fields.PageTitle());
    }
}
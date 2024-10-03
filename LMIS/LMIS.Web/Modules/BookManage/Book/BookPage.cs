using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.BookManage.Pages;

[PageAuthorize(typeof(BookRow))]
public class BookPage : Controller
{
    [Route("BookManage/Book")]
    public ActionResult Index()
    {
        return this.GridPage("@/BookManage/Book/BookPage",
            BookRow.Fields.PageTitle());
    }
}
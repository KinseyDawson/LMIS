using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.BookManage.Pages;

[PageAuthorize(typeof(BookshelfRow))]
public class BookshelfPage : Controller
{
    [Route("BookManage/Bookshelf")]
    public ActionResult Index()
    {
        return this.GridPage("@/BookManage/Bookshelf/BookshelfPage",
            BookshelfRow.Fields.PageTitle());
    }
}
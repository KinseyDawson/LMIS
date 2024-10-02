using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.BookManage.Pages;

[PageAuthorize(typeof(BookshelfsRow))]
public class BookshelfsPage : Controller
{
    [Route("BookManage/Bookshelfs")]
    public ActionResult Index()
    {
        return this.GridPage("@/BookManage/Bookshelfs/BookshelfsPage",
            BookshelfsRow.Fields.PageTitle());
    }
}
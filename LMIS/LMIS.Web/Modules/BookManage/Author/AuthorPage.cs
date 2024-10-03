using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.BookManage.Pages;

[PageAuthorize(typeof(AuthorRow))]
public class AuthorPage : Controller
{
    [Route("BookManage/Author")]
    public ActionResult Index()
    {
        return this.GridPage("@/BookManage/Author/AuthorPage",
            AuthorRow.Fields.PageTitle());
    }
}
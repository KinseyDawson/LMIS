using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.BookManage.Pages;

[PageAuthorize(typeof(AuthorsRow))]
public class AuthorsPage : Controller
{
    [Route("BookManage/Authors")]
    public ActionResult Index()
    {
        return this.GridPage("@/BookManage/Authors/AuthorsPage",
            AuthorsRow.Fields.PageTitle());
    }
}
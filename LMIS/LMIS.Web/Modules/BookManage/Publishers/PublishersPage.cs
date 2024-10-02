using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.BookManage.Pages;

[PageAuthorize(typeof(PublishersRow))]
public class PublishersPage : Controller
{
    [Route("BookManage/Publishers")]
    public ActionResult Index()
    {
        return this.GridPage("@/BookManage/Publishers/PublishersPage",
            PublishersRow.Fields.PageTitle());
    }
}
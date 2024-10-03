using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.BookManage.Pages;

[PageAuthorize(typeof(PublisherRow))]
public class PublisherPage : Controller
{
    [Route("BookManage/Publisher")]
    public ActionResult Index()
    {
        return this.GridPage("@/BookManage/Publisher/PublisherPage",
            PublisherRow.Fields.PageTitle());
    }
}
using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.ReaderManage.Pages;

[PageAuthorize(typeof(LibraryCardsRow))]
public class LibraryCardsPage : Controller
{
    [Route("ReaderManage/LibraryCards")]
    public ActionResult Index()
    {
        return this.GridPage("@/ReaderManage/LibraryCards/LibraryCardsPage",
            LibraryCardsRow.Fields.PageTitle());
    }
}
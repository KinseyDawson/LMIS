using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.ReaderManage.Pages;

[PageAuthorize(typeof(LibraryCardLoseRow))]
public class LibraryCardLosePage : Controller
{
    [Route("ReaderManage/LibraryCardLose")]
    public ActionResult Index()
    {
        return this.GridPage("@/ReaderManage/LibraryCardLose/LibraryCardLosePage",
            LibraryCardLoseRow.Fields.PageTitle());
    }
}
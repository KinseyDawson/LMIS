using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.ReaderManage.Pages;

[PageAuthorize(typeof(LibraryCardRow))]
public class LibraryCardPage : Controller
{
    [Route("ReaderManage/LibraryCard")]
    public ActionResult Index()
    {
        return this.GridPage("@/ReaderManage/LibraryCard/LibraryCardPage",
            LibraryCardRow.Fields.PageTitle());
    }
}
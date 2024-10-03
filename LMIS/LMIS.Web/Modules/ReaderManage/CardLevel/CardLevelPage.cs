using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.ReaderManage.Pages;

[PageAuthorize(typeof(CardLevelRow))]
public class CardLevelPage : Controller
{
    [Route("ReaderManage/CardLevel")]
    public ActionResult Index()
    {
        return this.GridPage("@/ReaderManage/CardLevel/CardLevelPage",
            CardLevelRow.Fields.PageTitle());
    }
}
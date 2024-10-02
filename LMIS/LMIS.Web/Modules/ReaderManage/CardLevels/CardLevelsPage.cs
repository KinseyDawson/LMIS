using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace LMIS.ReaderManage.Pages;

[PageAuthorize(typeof(CardLevelsRow))]
public class CardLevelsPage : Controller
{
    [Route("ReaderManage/CardLevels")]
    public ActionResult Index()
    {
        return this.GridPage("@/ReaderManage/CardLevels/CardLevelsPage",
            CardLevelsRow.Fields.PageTitle());
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.BookManage.CategoriesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.BookManage.CategoriesRow;

namespace LMIS.BookManage;

public interface ICategoriesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class CategoriesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriesSaveHandler
{
    public CategoriesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.BookManage.CategoriesRow>;
using MyRow = LMIS.BookManage.CategoriesRow;

namespace LMIS.BookManage;

public interface ICategoriesListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class CategoriesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriesListHandler
{
    public CategoriesListHandler(IRequestContext context)
            : base(context)
    {
    }
}
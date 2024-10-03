using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.BookManage.CategoryRow>;
using MyRow = LMIS.BookManage.CategoryRow;

namespace LMIS.BookManage;

public interface ICategoryListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class CategoryListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICategoryListHandler
{
    public CategoryListHandler(IRequestContext context)
            : base(context)
    {
    }
}
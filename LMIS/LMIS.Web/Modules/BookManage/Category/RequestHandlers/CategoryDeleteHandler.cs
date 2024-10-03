using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.BookManage.CategoryRow;

namespace LMIS.BookManage;

public interface ICategoryDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class CategoryDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICategoryDeleteHandler
{
    public CategoryDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
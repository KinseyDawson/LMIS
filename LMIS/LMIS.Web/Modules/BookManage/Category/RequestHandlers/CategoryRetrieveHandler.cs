using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.BookManage.CategoryRow>;
using MyRow = LMIS.BookManage.CategoryRow;

namespace LMIS.BookManage;

public interface ICategoryRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class CategoryRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoryRetrieveHandler
{
    public CategoryRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
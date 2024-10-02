using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.BookManage.CategoriesRow>;
using MyRow = LMIS.BookManage.CategoriesRow;

namespace LMIS.BookManage;

public interface ICategoriesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class CategoriesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriesRetrieveHandler
{
    public CategoriesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
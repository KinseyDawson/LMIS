using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.BookManage.PublishersRow>;
using MyRow = LMIS.BookManage.PublishersRow;

namespace LMIS.BookManage;

public interface IPublishersRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class PublishersRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPublishersRetrieveHandler
{
    public PublishersRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
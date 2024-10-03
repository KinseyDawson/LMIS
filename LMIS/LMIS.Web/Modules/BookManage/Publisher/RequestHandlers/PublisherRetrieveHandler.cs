using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.BookManage.PublisherRow>;
using MyRow = LMIS.BookManage.PublisherRow;

namespace LMIS.BookManage;

public interface IPublisherRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class PublisherRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPublisherRetrieveHandler
{
    public PublisherRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
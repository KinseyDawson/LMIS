using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.BookManage.PublisherRow>;
using MyRow = LMIS.BookManage.PublisherRow;

namespace LMIS.BookManage;

public interface IPublisherListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class PublisherListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPublisherListHandler
{
    public PublisherListHandler(IRequestContext context)
            : base(context)
    {
    }
}
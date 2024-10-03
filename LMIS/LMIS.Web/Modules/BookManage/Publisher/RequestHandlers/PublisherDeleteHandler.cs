using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.BookManage.PublisherRow;

namespace LMIS.BookManage;

public interface IPublisherDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class PublisherDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPublisherDeleteHandler
{
    public PublisherDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.BookManage.PublishersRow;

namespace LMIS.BookManage;

public interface IPublishersDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class PublishersDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPublishersDeleteHandler
{
    public PublishersDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
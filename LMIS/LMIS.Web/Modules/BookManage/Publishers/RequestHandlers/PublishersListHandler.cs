using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.BookManage.PublishersRow>;
using MyRow = LMIS.BookManage.PublishersRow;

namespace LMIS.BookManage;

public interface IPublishersListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class PublishersListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPublishersListHandler
{
    public PublishersListHandler(IRequestContext context)
            : base(context)
    {
    }
}
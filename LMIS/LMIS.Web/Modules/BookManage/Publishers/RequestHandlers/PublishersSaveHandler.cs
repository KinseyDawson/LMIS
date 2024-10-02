using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.BookManage.PublishersRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.BookManage.PublishersRow;

namespace LMIS.BookManage;

public interface IPublishersSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class PublishersSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPublishersSaveHandler
{
    public PublishersSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
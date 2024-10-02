using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.ReaderManage.CardLevelsRow>;
using MyRow = LMIS.ReaderManage.CardLevelsRow;

namespace LMIS.ReaderManage;

public interface ICardLevelsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class CardLevelsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICardLevelsListHandler
{
    public CardLevelsListHandler(IRequestContext context)
            : base(context)
    {
    }
}
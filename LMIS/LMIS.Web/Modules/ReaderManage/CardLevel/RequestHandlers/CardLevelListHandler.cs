using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<LMIS.ReaderManage.CardLevelRow>;
using MyRow = LMIS.ReaderManage.CardLevelRow;

namespace LMIS.ReaderManage;

public interface ICardLevelListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class CardLevelListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICardLevelListHandler
{
    public CardLevelListHandler(IRequestContext context)
            : base(context)
    {
    }
}
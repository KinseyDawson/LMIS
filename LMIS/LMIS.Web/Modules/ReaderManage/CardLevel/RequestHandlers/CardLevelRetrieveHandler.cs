using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.ReaderManage.CardLevelRow>;
using MyRow = LMIS.ReaderManage.CardLevelRow;

namespace LMIS.ReaderManage;

public interface ICardLevelRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class CardLevelRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICardLevelRetrieveHandler
{
    public CardLevelRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
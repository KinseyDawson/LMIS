using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LMIS.ReaderManage.CardLevelsRow>;
using MyRow = LMIS.ReaderManage.CardLevelsRow;

namespace LMIS.ReaderManage;

public interface ICardLevelsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class CardLevelsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICardLevelsRetrieveHandler
{
    public CardLevelsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
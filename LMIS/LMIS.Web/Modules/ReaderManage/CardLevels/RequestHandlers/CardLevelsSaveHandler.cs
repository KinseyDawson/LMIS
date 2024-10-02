using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.ReaderManage.CardLevelsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.ReaderManage.CardLevelsRow;

namespace LMIS.ReaderManage;

public interface ICardLevelsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class CardLevelsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICardLevelsSaveHandler
{
    public CardLevelsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
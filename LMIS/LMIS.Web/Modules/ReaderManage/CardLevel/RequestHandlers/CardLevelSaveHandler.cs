using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.ReaderManage.CardLevelRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.ReaderManage.CardLevelRow;

namespace LMIS.ReaderManage;

public interface ICardLevelSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class CardLevelSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICardLevelSaveHandler
{
    public CardLevelSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
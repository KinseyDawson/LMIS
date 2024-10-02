using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.ReaderManage.CardLevelsRow;

namespace LMIS.ReaderManage;

public interface ICardLevelsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class CardLevelsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICardLevelsDeleteHandler
{
    public CardLevelsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
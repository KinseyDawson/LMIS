using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.ReaderManage.CardLevelRow;

namespace LMIS.ReaderManage;

public interface ICardLevelDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class CardLevelDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICardLevelDeleteHandler
{
    public CardLevelDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
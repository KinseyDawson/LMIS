using MySql.Data.MySqlClient;
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
    protected override void ExecuteSave()
    {
        try
        {
            base.ExecuteSave();
        }
        catch (MySqlException ex) when (ex.Message.StartsWith("duplicate", StringComparison.OrdinalIgnoreCase))
        {
            throw new ValidationError(Texts.Validation.CardLevelUniqueError.ToString(Localizer));
        }
    }
    protected override void ValidateRequest()
    {
        if (IsCreate)
        {
            Row.CreateTime = DateTime.Now;
        }
        Row.UpdateTime = DateTime.Now;
        base.ValidateRequest();
    }
}
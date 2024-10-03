using MySql.Data.MySqlClient;
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.BookManage.PublisherRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.BookManage.PublisherRow;

namespace LMIS.BookManage;

public interface IPublisherSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class PublisherSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPublisherSaveHandler
{
    public PublisherSaveHandler(IRequestContext context)
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
            throw new ValidationError(Texts.Validation.PublisherUniqueError.ToString(Localizer));
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
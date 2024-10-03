using MySql.Data.MySqlClient;
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.BookManage.PublishersRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.BookManage.PublishersRow;

namespace LMIS.BookManage;

public interface IPublishersSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class PublishersSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPublishersSaveHandler
{
    public PublishersSaveHandler(IRequestContext context)
            : base(context)
    {
    }
    protected override void ExecuteSave()
    {
        try
        {
            base.ExecuteSave();
        }
        catch (MySqlException ex) when (ex.Message.StartsWith("Duplicate"))
        {
            throw new ValidationError(Texts.Validation.PublisherUniqueError.ToString(Localizer));
        }
    }
    protected override void ValidateRequest()
    {
        if (IsCreate)
        {
            Row.CreateTime = DateTime.Now;
            Row.UpdateTime = DateTime.Now;
        }
        else
        {
            Row.UpdateTime = DateTime.Now;
        }
        base.ValidateRequest();
    }
}
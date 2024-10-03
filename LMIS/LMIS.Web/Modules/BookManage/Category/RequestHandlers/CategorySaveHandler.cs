using MySql.Data.MySqlClient;
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.BookManage.CategoryRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.BookManage.CategoryRow;

namespace LMIS.BookManage;

public interface ICategorySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class CategorySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategorySaveHandler
{
    public CategorySaveHandler(IRequestContext context)
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
            throw new ValidationError(Texts.Validation.CategoryUniqueError.ToString(Localizer));
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
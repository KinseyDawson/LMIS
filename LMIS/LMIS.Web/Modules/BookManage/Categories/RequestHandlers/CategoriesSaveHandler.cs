using MySql.Data.MySqlClient;
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.BookManage.CategoriesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.BookManage.CategoriesRow;

namespace LMIS.BookManage;

public interface ICategoriesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class CategoriesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriesSaveHandler
{
    public CategoriesSaveHandler(IRequestContext context)
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
            throw new ValidationError(Texts.Validation.CategoryUniqueError.ToString(Localizer));
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
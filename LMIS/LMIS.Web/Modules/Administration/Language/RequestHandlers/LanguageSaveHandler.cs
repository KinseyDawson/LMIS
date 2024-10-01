using MyRequest = Serenity.Services.SaveRequest<LMIS.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.Administration.LanguageRow;


namespace LMIS.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}
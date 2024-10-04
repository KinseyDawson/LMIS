using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<LMIS.ReaderManage.UserBillRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = LMIS.ReaderManage.UserBillRow;

namespace LMIS.ReaderManage;

public interface IUserBillSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class UserBillSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IUserBillSaveHandler
{
    public UserBillSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
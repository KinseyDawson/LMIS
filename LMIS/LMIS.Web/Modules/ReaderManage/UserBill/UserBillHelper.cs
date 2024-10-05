namespace LMIS.Modules.ReaderManage.UserBill;
using MyRow = LMIS.ReaderManage.UserBillRow;

public class UserBillHelper
{
    private static MyRow.RowFields Fld => MyRow.Fields;

    public static void Insert(IDbConnection connection, long userId, BillTypeEnum billType, decimal fee, string remark)
    {
        var sql = new SqlInsert("userbills")
               .SetTo(Fld.UserId, userId.ToString())
               .SetTo(Fld.Type, ((int)billType).ToString())
               .SetTo(Fld.Fee, fee.ToString())
               .SetTo(Fld.Remark, $"'{remark.ToString()}'")
               .SetTo(Fld.CreateTime, $"'{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}'")
               .SetTo(Fld.UpdateTime, $"'{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}'");
        sql.Execute(connection);
    }
}

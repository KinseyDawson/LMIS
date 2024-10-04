namespace LMIS.Modules.ReaderManage.Borrow;

using Dapper;
using MyRow = LMIS.ReaderManage.BorrowRow;

public class BorrowHelper
{
    private static MyRow.RowFields Fld => MyRow.Fields;
    public static long QueryBorrowedCount(IDbConnection connection, long userId)
    {
        var sqlText = @"select count(1) from borrows where UserId=@UserId and BorrowStatus=1";
        return connection.ExecuteScalar<long>(sqlText, new { UserId = userId });
    }
}

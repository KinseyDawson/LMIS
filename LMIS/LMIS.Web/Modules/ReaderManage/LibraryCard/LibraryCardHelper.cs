namespace LMIS.Modules.ReaderManage.LibraryCard;

using MyRow = LMIS.ReaderManage.LibraryCardRow;
public class LibraryCardHelper
{
    private static MyRow.RowFields Fld => MyRow.Fields;
    public static MyRow QueryByUserId(IDbConnection connection, long userId, LibraryCardStatusEnum status)
    {
        var row = new MyRow();
        if (new SqlQuery().From(row)
            .Select(
                Fld.LibraryCardId,
                Fld.LibraryCardNo,
                Fld.UserId,
                Fld.LevelId,
                Fld.Status)
            .Where(new Criteria(Fld.UserId) == userId)
            .Where(new Criteria(Fld.Status)== (int)status)
            .GetFirst(connection))
        {
            return row;
        }
        return null;
    }
}

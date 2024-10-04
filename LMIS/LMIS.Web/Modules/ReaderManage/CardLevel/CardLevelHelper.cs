namespace LMIS.Modules.ReaderManage.CardLevel;

using MyRow = LMIS.ReaderManage.CardLevelRow;
public class CardLevelHelper
{
    private static MyRow.RowFields Fld => MyRow.Fields;
    public static MyRow QueryByCardLevelId(IDbConnection connection, long cardLevelId)
    {
        var row = new MyRow();
        if (new SqlQuery().From(row)
            .Select(
                Fld.CardLevelId,
                Fld.CardLevelName,
                Fld.Fee,
                Fld.Rent,
                Fld.Discount,
                Fld.Penalty,
                Fld.BorrowBooks,
                Fld.BorrowDays)
            .Where(new Criteria(Fld.CardLevelId) == cardLevelId)
            .GetFirst(connection))
        {
            return row;
        }
        return null;
    }
}

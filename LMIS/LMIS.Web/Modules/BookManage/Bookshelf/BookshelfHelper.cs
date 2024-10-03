namespace LMIS.Modules.BookManage.Bookshelf;
using MyRow = LMIS.BookManage.BookshelfRow;

public class BookshelfHelper
{
    private static MyRow.RowFields Fld => MyRow.Fields;
    public static MyRow QueryById(IDbConnection connection, long bookshelfId)
    {
        var row = new MyRow();
        if (new SqlQuery().From(row)
            .Select(
                Fld.BookshelfId,
                Fld.Location,
                Fld.BookCount,
                Fld.BookCapacity)
            .Where(new Criteria(Fld.BookshelfId) == bookshelfId)
            .GetFirst(connection))
        {
            return row;
        }
        return null;
    }
    public static void Up(IDbConnection connection, long bookshelfId, long inventory)
    {
        var sqlText = @"update Bookshelfs
                        set
                        BookCount =BookCount +@Inventory
                        where BookshelfId=@BookshelfId";
        connection.Execute(sqlText, new { BookshelfId = bookshelfId, Inventory = inventory });
    }
    public static void Down(IDbConnection connection, long bookshelfId, long inventory)
    {
        var sqlText = @"update Bookshelfs
                        set
                        BookCount =BookCount -@Inventory
                        where BookshelfId=@BookshelfId";
        connection.Execute(sqlText, new { BookshelfId = bookshelfId, Inventory = inventory });
    }
}
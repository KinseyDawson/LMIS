namespace LMIS.Modules.BookManage.Book;

using Dapper;
using MyRow = LMIS.BookManage.BookRow;

public class BookHelper
{
    private static MyRow.RowFields Fld => MyRow.Fields;
    public static void DownBookshelf(IDbConnection connection, long bookId)
    {
        connection.Execute("", new { BookId = bookId });
    }
}

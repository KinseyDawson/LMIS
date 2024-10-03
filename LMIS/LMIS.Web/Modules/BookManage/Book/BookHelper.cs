namespace LMIS.Modules.BookManage.Book;

using Dapper;
using MyRow = LMIS.BookManage.BookRow;

public class BookHelper
{
    private static MyRow.RowFields Fld => MyRow.Fields;
    public static void IncreaseInventory(IDbConnection connection, long bookId, long amount)
    {
        var sqlText = @"update Books
                        set
                        Inventory =Inventory +@Amount,
                        BorrowableInventory =BorrowableInventory +@Amount
                        where BookId=@BookId";
        connection.Execute(sqlText, new { BookId = bookId, Amount = amount });
    }
    public static void DncreaseInventory(IDbConnection connection, long bookId, long amount)
    {
        var sqlText = @"update Books
                        set
                        Inventory =Inventory -@Amount,
                        BorrowableInventory =BorrowableInventory -@Amount
                        where BookId=@BookId";
        connection.Execute(sqlText, new { BookId = bookId, Amount = amount });
    }
}

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
    public static void DecreaseInventory(IDbConnection connection, long bookId, long amount)
    {
        var sqlText = @"update Books
                        set
                        Inventory =Inventory -@Amount,
                        BorrowableInventory =BorrowableInventory -@Amount
                        where BookId=@BookId";
        connection.Execute(sqlText, new { BookId = bookId, Amount = amount });
    }
    public static void DncreaseStockInventory(IDbConnection connection, long bookId, long amount)
    {
        var sqlText = @"update Books
                        set
                        Inventory =Inventory -@Amount
                        where BookId=@BookId";
        connection.Execute(sqlText, new { BookId = bookId, Amount = amount });
    }

    public static MyRow QueryByBookId(IDbConnection connection, long bookId)
    {
        var row = new MyRow();
        if (new SqlQuery().From(row)
            .Select(
                Fld.BookId,
                Fld.BookName,
                Fld.Price,
                Fld.Inventory,
                Fld.BorrowableInventory,
                Fld.BookStatus)
            .Where(new Criteria(Fld.BookId) == bookId)
            .GetFirst(connection))
        {
            return row;
        }
        return null;
    }
    public static void DncreaseBorrowableInventory(IDbConnection connection, long bookId, long amount)
    {
        var sqlText = @"update Books
                        set
                        BorrowableInventory =BorrowableInventory -@Amount
                        where BookId=@BookId";
        connection.Execute(sqlText, new { BookId = bookId, Amount = amount });
    }
    public static void IncreaseBorrowableInventory(IDbConnection connection, long bookId, long amount)
    {
        var sqlText = @"update Books
                        set
                        BorrowableInventory =BorrowableInventory +@Amount
                        where BookId=@BookId";
        connection.Execute(sqlText, new { BookId = bookId, Amount = amount });
    }

}

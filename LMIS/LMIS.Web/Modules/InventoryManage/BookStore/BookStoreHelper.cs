namespace LMIS.Modules.InventoryManage.BookStore;
using Serenity.Data;
using System.Linq;
using MyRow = LMIS.InventoryManage.BookStoreRow;

public class BookStoreHelper
{
    private static MyRow.RowFields Fld => MyRow.Fields;
    public static MyRow QueryByBookIdAndBookshelfId(IDbConnection connection, long bookId, long bookshelfId)
    {
        var row = new MyRow();
        if (new SqlQuery().From(row)
            .Select(
                Fld.BookId,
                Fld.BookshelfId,
                Fld.Inventory)
            .Where(new Criteria(Fld.BookId) == bookId)
            .Where(new Criteria(Fld.BookshelfId) == bookshelfId)
            .GetFirst(connection))
        {
            return row;
        }
        return null;
    }
    public static void Insert(IDbConnection connection, long bookId, long bookshelfId, long inventory)
    {
        var sql = new SqlInsert("bookstores")
               .SetTo(Fld.BookId, bookId.ToString())
               .SetTo(Fld.BookshelfId, bookshelfId.ToString())
               .SetTo(Fld.Inventory, inventory.ToString())
               .SetTo(Fld.CreateTime, $"'{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}'")
               .SetTo(Fld.UpdateTime, $"'{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}'");
        sql.Execute(connection);
    }

    public static void Increase(IDbConnection connection, long bookId, long bookshelfId, long inventory)
    {
        var sqlText = @"update
	                        BookStores
                        set
	                        Inventory = Inventory+@Inventory,
	                        UpdateTime = @CurrentTime
                        where
	                        BookId = @BookId
	                        and BookshelfId = @BookshelfId;";
        connection.Execute(sqlText, new
        {
            BookId = bookId,
            BookshelfId = bookshelfId,
            Inventory = inventory,
            CurrentTime = DateTime.Now
        });
    }
    public static void Decrease(IDbConnection connection, long bookId, long bookshelfId, long inventory)
    {
        var sqlText = @"update
	                        BookStores
                        set
	                        Inventory = Inventory-@Inventory,
	                        UpdateTime = @CurrentTime
                        where
	                        BookId = @BookId
	                        and BookshelfId = @BookshelfId;";
        connection.Execute(sqlText, new
        {
            BookId = bookId,
            BookshelfId = bookshelfId,
            Inventory = inventory,
            CurrentTime = DateTime.Now
        });
    }
}

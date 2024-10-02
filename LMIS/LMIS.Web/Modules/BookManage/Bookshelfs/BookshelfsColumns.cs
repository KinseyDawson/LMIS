using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.BookManage.Columns;

[ColumnsScript("BookManage.Bookshelfs")]
[BasedOnRow(typeof(BookshelfsRow), CheckNames = true)]
public class BookshelfsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public long BookshelfId { get; set; }
    [EditLink]
    public string Location { get; set; }
    public string CategoryName { get; set; }
    public string BookshelfImage { get; set; }
    public long BookCount { get; set; }
    public long BookCapacity { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
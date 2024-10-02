using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.BookManage.Columns;

[ColumnsScript("BookManage.Bookshelfs")]
[BasedOnRow(typeof(BookshelfsRow), CheckNames = true)]
public class BookshelfsColumns
{
    [EditLink, AlignRight]
    public long BookshelfId { get; set; }
    [EditLink]
    public string Location { get; set; }
    public string CategoryName { get; set; }
    public string BookshelfImage { get; set; }
    public long BookCount { get; set; }
    public long BookCapacity { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime CreateTime { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime UpdateTime { get; set; }
}
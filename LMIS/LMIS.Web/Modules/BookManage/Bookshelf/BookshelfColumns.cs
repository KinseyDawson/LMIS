using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.BookManage.Columns;

[ColumnsScript("BookManage.Bookshelf")]
[BasedOnRow(typeof(BookshelfRow), CheckNames = true)]
public class BookshelfColumns
{
    //[EditLink, AlignRight]
    //public long BookshelfId { get; set; }
    [EditLink]
    public string Location { get; set; }
    public string CategoryName { get; set; }
    public long BookCount { get; set; }
    public long BookCapacity { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime UpdateTime { get; set; }
}
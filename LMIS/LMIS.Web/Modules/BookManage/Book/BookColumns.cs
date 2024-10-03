using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.BookManage.Columns;

[ColumnsScript("BookManage.Book")]
[BasedOnRow(typeof(BookRow), CheckNames = true)]
public class BookColumns
{
    [EditLink, AlignRight]
    public long BookId { get; set; }
    [EditLink]
    public string BookName { get; set; }
    public string CN { get; set; }
    public string ISSN { get; set; }
    public string ISBN { get; set; }
    public string AuthorName { get; set; }
    public string PublisherName { get; set; }
    [Width(100)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd")]
    public DateTime PublisheDate { get; set; }
    public int Page { get; set; }
    public decimal Price { get; set; }
    public long Inventory { get; set; }
    public long BorrowableInventory { get; set; }
    public short BookStatus { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime UpdateTime { get; set; }
}
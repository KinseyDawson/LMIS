using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.BookManage.Columns;

[ColumnsScript("BookManage.Books")]
[BasedOnRow(typeof(BooksRow), CheckNames = true)]
public class BooksColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public long BookId { get; set; }
    [EditLink]
    public string BookName { get; set; }
    public string Cn { get; set; }
    public string Issn { get; set; }
    public string Isbn { get; set; }
    public string AuthorName { get; set; }
    public string PublisherName { get; set; }
    public DateTime PublisheDate { get; set; }
    public int Page { get; set; }
    public decimal Price { get; set; }
    public long Inventory { get; set; }
    public short BookStatus { get; set; }
    public string BookImage { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
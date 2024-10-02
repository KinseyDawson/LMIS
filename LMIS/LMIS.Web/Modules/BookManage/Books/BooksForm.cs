using Serenity.ComponentModel;
using System;

namespace LMIS.BookManage.Forms;

[FormScript("BookManage.Books")]
[BasedOnRow(typeof(BooksRow), CheckNames = true)]
public class BooksForm
{
    public string BookName { get; set; }
    public string Cn { get; set; }
    public string Issn { get; set; }
    public string Isbn { get; set; }
    public long AuthorId { get; set; }
    public long PublisherId { get; set; }
    public DateTime PublisheDate { get; set; }
    public int Page { get; set; }
    public decimal Price { get; set; }
    public long Inventory { get; set; }
    public short BookStatus { get; set; }
    public string BookImage { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
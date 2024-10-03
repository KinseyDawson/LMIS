using LMIS.Modules.BookManage.Book;
using Serenity.ComponentModel;
using System;

namespace LMIS.BookManage.Forms;

[FormScript("BookManage.Book")]
[BasedOnRow(typeof(BookRow), CheckNames = true)]
public class BookForm
{
    public string BookName { get; set; }
    public string CN { get; set; }
    public string ISSN { get; set; }
    public string ISBN { get; set; }
    public long AuthorId { get; set; }
    public long PublisherId { get; set; }
    [DateEditor]
    public DateTime PublisheDate { get; set; }
    [IntegerEditor]
    public int Page { get; set; }
    [DecimalEditor]
    public decimal Price { get; set; }
    public BookStatusEnum BookStatus { get; set; }
    public string BookImage { get; set; }
}
using Serenity.ComponentModel;
using System;

namespace LMIS.BookManage.Forms;

[FormScript("BookManage.Bookshelfs")]
[BasedOnRow(typeof(BookshelfsRow), CheckNames = true)]
public class BookshelfsForm
{
    public string Location { get; set; }
    public long CategoryId { get; set; }
    public string BookshelfImage { get; set; }
    public long BookCount { get; set; }
    public long BookCapacity { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
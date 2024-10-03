using Serenity.ComponentModel;
using System;

namespace LMIS.BookManage.Forms;

[FormScript("BookManage.Bookshelf")]
[BasedOnRow(typeof(BookshelfRow), CheckNames = true)]
public class BookshelfForm
{
    public string Location { get; set; }
    public long CategoryId { get; set; }
    public string BookshelfImage { get; set; }
    [IntegerEditor]
    public long BookCapacity { get; set; }
}
using Serenity.ComponentModel;
using System;

namespace LMIS.InventoryManage.Forms;

[FormScript("InventoryManage.BookStore")]
[BasedOnRow(typeof(BookStoreRow), CheckNames = true)]
public class BookStoreForm
{
    public long BookId { get; set; }
    public long BookshelfId { get; set; }
    public long Inventory { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
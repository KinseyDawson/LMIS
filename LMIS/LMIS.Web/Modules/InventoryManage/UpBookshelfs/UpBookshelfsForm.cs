using Serenity.ComponentModel;
using System;

namespace LMIS.InventoryManage.Forms;

[FormScript("InventoryManage.UpBookshelfs")]
[BasedOnRow(typeof(UpBookshelfsRow), CheckNames = true)]
public class UpBookshelfsForm
{
    public long BookId { get; set; }
    public long BookshelfId { get; set; }
    public long Inventory { get; set; }
    public long OperateUserId { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
using Serenity.ComponentModel;
using System;

namespace LMIS.InventoryManage.Forms;

[FormScript("InventoryManage.UpBookshelf")]
[BasedOnRow(typeof(UpBookshelfRow), CheckNames = true)]
public class UpBookshelfForm
{
    public long BookId { get; set; }
    public long BookshelfId { get; set; }
    public long Inventory { get; set; }
    public long OperateUserId { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
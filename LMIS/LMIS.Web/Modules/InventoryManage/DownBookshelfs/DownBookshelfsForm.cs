using Serenity.ComponentModel;
using System;

namespace LMIS.InventoryManage.Forms;

[FormScript("InventoryManage.DownBookshelfs")]
[BasedOnRow(typeof(DownBookshelfsRow), CheckNames = true)]
public class DownBookshelfsForm
{
    public long BookId { get; set; }
    public long BookshelfId { get; set; }
    public long OperateUserId { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
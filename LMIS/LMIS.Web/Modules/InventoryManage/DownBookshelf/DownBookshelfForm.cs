using Serenity.ComponentModel;
using System;

namespace LMIS.InventoryManage.Forms;

[FormScript("InventoryManage.DownBookshelf")]
[BasedOnRow(typeof(DownBookshelfRow), CheckNames = true)]
public class DownBookshelfForm
{
    public long BookId { get; set; }
    public long BookshelfId { get; set; }
    [IntegerEditor]
    public long Inventory { get; set; }
    public string Remark { get; set; }

}
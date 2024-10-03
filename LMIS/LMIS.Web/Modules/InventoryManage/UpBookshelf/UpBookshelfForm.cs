using Serenity.ComponentModel;
using System;

namespace LMIS.InventoryManage.Forms;

[FormScript("InventoryManage.UpBookshelf")]
[BasedOnRow(typeof(UpBookshelfRow), CheckNames = true)]
public class UpBookshelfForm
{
    public long BookId { get; set; }
    public long BookshelfId { get; set; }
    [IntegerEditor]
    public long Inventory { get; set; }
}
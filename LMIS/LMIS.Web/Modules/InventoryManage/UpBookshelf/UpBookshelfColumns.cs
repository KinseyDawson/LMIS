using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.InventoryManage.Columns;

[ColumnsScript("InventoryManage.UpBookshelf")]
[BasedOnRow(typeof(UpBookshelfRow), CheckNames = true)]
public class UpBookshelfColumns
{
    [EditLink,AlignRight]
    public long UpBookshelfId { get; set; }
    public string BookName { get; set; }
    public string BookshelfLocation { get; set; }
    public long Inventory { get; set; }
    public string OperateUserUsername { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
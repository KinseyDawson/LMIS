using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.InventoryManage.Columns;

[ColumnsScript("InventoryManage.DownBookshelf")]
[BasedOnRow(typeof(DownBookshelfRow), CheckNames = true)]
public class DownBookshelfColumns
{
    [EditLink,AlignRight]
    public long DownBookshelfId { get; set; }
    public string BookName { get; set; }
    public string BookshelfLocation { get; set; }
    public string OperateUserUsername { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
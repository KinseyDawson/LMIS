using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.InventoryManage.Columns;

[ColumnsScript("InventoryManage.UpBookshelf")]
[BasedOnRow(typeof(UpBookshelfRow), CheckNames = true)]
public class UpBookshelfColumns
{
    [AlignRight]
    public long UpBookshelfId { get; set; }
    public string BookName { get; set; }
    public string BookshelfLocation { get; set; }
    public long Inventory { get; set; }
    public string OperateUserName { get; set; }
    [Width(200)]
    public string Remark { get; set; }
    
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime CreateTime { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime UpdateTime { get; set; }
}
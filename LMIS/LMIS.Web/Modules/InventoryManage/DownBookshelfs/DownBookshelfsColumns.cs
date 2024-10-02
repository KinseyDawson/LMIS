using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.InventoryManage.Columns;

[ColumnsScript("InventoryManage.DownBookshelfs")]
[BasedOnRow(typeof(DownBookshelfsRow), CheckNames = true)]
public class DownBookshelfsColumns
{
    [EditLink,  AlignRight]
    public long DownBookshelfId { get; set; }
    public string BookName { get; set; }
    public string BookshelfLocation { get; set; }
    public string OperateUserName { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime CreateTime { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime UpdateTime { get; set; }
}
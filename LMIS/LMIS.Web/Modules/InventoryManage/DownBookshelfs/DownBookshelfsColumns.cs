using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.InventoryManage.Columns;

[ColumnsScript("InventoryManage.DownBookshelfs")]
[BasedOnRow(typeof(DownBookshelfsRow), CheckNames = true)]
public class DownBookshelfsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public long DownBookshelfId { get; set; }
    public string BookName { get; set; }
    public string BookshelfLocation { get; set; }
    public string OperateUserName { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
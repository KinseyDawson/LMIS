using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.InventoryManage.Columns;

[ColumnsScript("InventoryManage.UpBookshelfs")]
[BasedOnRow(typeof(UpBookshelfsRow), CheckNames = true)]
public class UpBookshelfsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public long UpBookshelfId { get; set; }
    public string BookName { get; set; }
    public string BookshelfLocation { get; set; }
    public long Inventory { get; set; }
    public string OperateUserName { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
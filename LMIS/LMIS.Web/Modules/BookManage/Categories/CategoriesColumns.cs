using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.BookManage.Columns;

[ColumnsScript("BookManage.Categories")]
[BasedOnRow(typeof(CategoriesRow), CheckNames = true)]
public class CategoriesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public long CategoryId { get; set; }
    [EditLink]
    public string CategoryName { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
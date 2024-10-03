using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.ReaderManage.Columns;

[ColumnsScript("ReaderManage.CardLevel")]
[BasedOnRow(typeof(CardLevelRow), CheckNames = true)]
public class CardLevelColumns
{
    [EditLink,AlignRight]
    public long CardLevelId { get; set; }
    [EditLink]
    public string CardLevelName { get; set; }
    public decimal Discount { get; set; }
    public decimal Penalty { get; set; }
    public int BorrowDays { get; set; }
    public int BorrowBooks { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
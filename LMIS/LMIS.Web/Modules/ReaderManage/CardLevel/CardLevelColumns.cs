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
    public decimal Fee { get; set; }
    public decimal Discount { get; set; }
    public decimal Penalty { get; set; }
    [Width(100)]
    public int BorrowDays { get; set; }
    [Width(100)]
    public int BorrowBooks { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime CreateTime { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime UpdateTime { get; set; }
}
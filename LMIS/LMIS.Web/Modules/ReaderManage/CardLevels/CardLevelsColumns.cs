using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.ReaderManage.Columns;

[ColumnsScript("ReaderManage.CardLevels")]
[BasedOnRow(typeof(CardLevelsRow), CheckNames = true)]
public class CardLevelsColumns
{
    [EditLink, AlignRight]
    public long CardLevelId { get; set; }
    [EditLink]
    public string CardLevelName { get; set; }
    public decimal Discount { get; set; }
    public decimal Penalty { get; set; }
    public int BorrowDays { get; set; }
    public int BorrowBooks { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime CreateTime { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime UpdateTime { get; set; }
}
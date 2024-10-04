using Serenity.ComponentModel;
using System;

namespace LMIS.ReaderManage.Forms;

[FormScript("ReaderManage.CardLevel")]
[BasedOnRow(typeof(CardLevelRow), CheckNames = true)]
public class CardLevelForm
{
    public string CardLevelName { get; set; }
    [DecimalEditor]
    public decimal Fee { get; set; }
    [DecimalEditor]
    public decimal Rent { get; set; }
    [DecimalEditor]
    public decimal Discount { get; set; }
    [DecimalEditor]
    public decimal Penalty { get; set; }
    [IntegerEditor]
    public int BorrowDays { get; set; }
    [IntegerEditor]
    public int BorrowBooks { get; set; }
}
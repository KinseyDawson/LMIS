﻿using Serenity.ComponentModel;
using System;

namespace LMIS.ReaderManage.Forms;

[FormScript("ReaderManage.CardLevels")]
[BasedOnRow(typeof(CardLevelsRow), CheckNames = true)]
public class CardLevelsForm
{
    public string CardLevelName { get; set; }
    public decimal Discount { get; set; }
    public decimal Penalty { get; set; }
    public int BorrowDays { get; set; }
    public int BorrowBooks { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
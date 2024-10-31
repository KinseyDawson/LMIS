using LMIS.Modules.ReaderManage.UserBill;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.ReaderManage.Columns;

[ColumnsScript("ReaderManage.UserBill")]
[BasedOnRow(typeof(UserBillRow), CheckNames = true)]
public class UserBillColumns
{
    //[AlignRight]
    //public long UserBillId { get; set; }
    public string UserName { get; set; }
    [Width(100)]
    public BillTypeEnum Type { get; set; }
    public decimal Fee { get; set; }
    [Width(300)]
    public string Remark { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime UpdateTime { get; set; }
}
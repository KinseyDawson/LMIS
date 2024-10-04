using LMIS.Modules.ReaderManage.UserBill;
using Serenity.ComponentModel;
using System;

namespace LMIS.ReaderManage.Forms;

[FormScript("ReaderManage.UserBill")]
[BasedOnRow(typeof(UserBillRow), CheckNames = true)]
public class UserBillForm
{
    public long UserId { get; set; }
    public BillTypeEnum Type { get; set; }
    public decimal Fee { get; set; }
    public string Remark { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
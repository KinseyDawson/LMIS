namespace LMIS.Modules.ReaderManage.UserBill;

public enum BillTypeEnum
{
    [Description("办卡")]
    Card = 1,
    [Description("借阅卡升级")]
    CardUpLevel = 2,
    [Description("借阅租金")]
    BookRent = 3,
    [Description("过期处罚")]
    ExpireedPenalty = 4,
    [Description("书籍赔偿")]
    BookCompensation = 5,
}

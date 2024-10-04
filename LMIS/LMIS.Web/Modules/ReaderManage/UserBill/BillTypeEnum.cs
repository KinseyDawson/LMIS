namespace LMIS.Modules.ReaderManage.UserBill;

public enum BillTypeEnum
{
    [Description("办卡")]
    Card = 1,
    [Description("补卡")]
    AppCard = 2,
    [Description("借阅卡升级")]
    CardUpLevel
}

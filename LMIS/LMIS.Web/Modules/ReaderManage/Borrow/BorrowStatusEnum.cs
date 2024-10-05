namespace LMIS.Modules.ReaderManage.Borrow;

public enum BorrowStatusEnum
{
    [Description("已借阅")]
    Borrowed = 1,
    [Description("已归还")]
    Returned = 2,
    [Description("过期归还")]
    ExpiredAndReturned = 3,
    [Description("损坏")]
    Damaged = 4,
}

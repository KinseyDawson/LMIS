
namespace LMIS.Common;

public class DashboardPageModel
{
    public int OpenOrders { get; set; }
    public int ClosedOrderPercent { get; set; }
    public int CustomerCount { get; set; }
    public int ProductCount { get; set; }
    public int BorrowedCount { get; set; }
    public int ExpiredAndBorrowedCount { get; set; }
    public int ReturnedCount { get; set; }
    public int DamageCount { get; set; }
}
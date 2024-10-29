
namespace LMIS.Common;

public class DashboardPageModel
{
    public int BorrowedCount { get; set; }
    public int ExpiredAndBorrowedCount { get; set; }
    public int ReturnedCount { get; set; }
    public int DamageCount { get; set; }
    public ChartStatistics BorrowType { get; set; }
    public ChartStatistics BillType { get; set; }

}

public class ChartStatistics
{
    public List<string> Labels { get; set; }
    public List<int> Datas { get; set; }
    public List<string> BackgroundColors { get; set; }
    public List<string> BorderColors { get; set; }
    public static ChartStatistics Empty
    {
        get
        {
            return new ChartStatistics
            {
                BackgroundColors = new List<string>(),
                BorderColors = new List<string>(),
                Datas = new List<int>(),
                Labels = new List<string>(),
            };
        }
    }
}
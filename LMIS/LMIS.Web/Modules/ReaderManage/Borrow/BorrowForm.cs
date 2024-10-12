using LMIS.Modules.ReaderManage.Borrow;

namespace LMIS.ReaderManage.Forms;

[FormScript("ReaderManage.Borrow")]
[BasedOnRow(typeof(BorrowRow), CheckNames = true)]
public class BorrowForm
{
    public long UserId { get; set; }
    public long BookId { get; set; }
    public long BookshelfId { get; set; }
    public BorrowStatusEnum BorrowStatus { get; set; }
}
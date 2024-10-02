using Serenity.ComponentModel;
using System;

namespace LMIS.ReaderManage.Forms;

[FormScript("ReaderManage.LibraryCardLose")]
[BasedOnRow(typeof(LibraryCardLoseRow), CheckNames = true)]
public class LibraryCardLoseForm
{
    public long LibraryCardId { get; set; }
    public long OperateUserId { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
using Serenity.ComponentModel;
using System;

namespace LMIS.ReaderManage.Forms;

[FormScript("ReaderManage.LibraryCard")]
[BasedOnRow(typeof(LibraryCardRow), CheckNames = true)]
public class LibraryCardForm
{
    public string LibraryCardNo { get; set; }
    public long UserId { get; set; }
    public long LevelId { get; set; }
    public short Status { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
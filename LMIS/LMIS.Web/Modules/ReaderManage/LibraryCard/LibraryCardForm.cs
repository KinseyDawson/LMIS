using LMIS.Modules.ReaderManage.LibraryCard;
using Serenity.ComponentModel;
using System;

namespace LMIS.ReaderManage.Forms;

[FormScript("ReaderManage.LibraryCard")]
[BasedOnRow(typeof(LibraryCardRow), CheckNames = true)]
public class LibraryCardForm
{
    public long UserId { get; set; }
    public long LevelId { get; set; }
    public LibraryCardStatusEnum Status { get; set; }
}
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.ReaderManage.Columns;

[ColumnsScript("ReaderManage.LibraryCard")]
[BasedOnRow(typeof(LibraryCardRow), CheckNames = true)]
public class LibraryCardColumns
{
    [EditLink,AlignRight]
    public long LibraryCardId { get; set; }
    [EditLink]
    public string LibraryCardNo { get; set; }
    public string Username { get; set; }
    public string LevelCardLevelName { get; set; }
    public short Status { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
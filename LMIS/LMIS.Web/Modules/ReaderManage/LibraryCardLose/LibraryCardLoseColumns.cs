using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.ReaderManage.Columns;

[ColumnsScript("ReaderManage.LibraryCardLose")]
[BasedOnRow(typeof(LibraryCardLoseRow), CheckNames = true)]
public class LibraryCardLoseColumns
{
    [EditLink,AlignRight]
    public long LibraryCardLoseId { get; set; }
    public string LibraryCardNo { get; set; }
    public string OperateUserUsername { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
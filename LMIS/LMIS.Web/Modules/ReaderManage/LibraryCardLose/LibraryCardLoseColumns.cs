using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.ReaderManage.Columns;

[ColumnsScript("ReaderManage.LibraryCardLose")]
[BasedOnRow(typeof(LibraryCardLoseRow), CheckNames = true)]
public class LibraryCardLoseColumns
{
    [EditLink, AlignRight]
    public long LibraryCardLostId { get; set; }
    public string LibraryCardNo { get; set; }
    public string OperateUserUsername { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime CreateTime { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime UpdateTime { get; set; }
}
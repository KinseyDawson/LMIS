using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.ReaderManage.Columns;

[ColumnsScript("ReaderManage.LibraryCards")]
[BasedOnRow(typeof(LibraryCardsRow), CheckNames = true)]
public class LibraryCardsColumns
{
    [EditLink,AlignRight]
    public long LibraryCardId { get; set; }
    [EditLink]
    public string LibraryCardNo { get; set; }
    public string Username { get; set; }
    public string LevelCardLevelName { get; set; }
    public short Status { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime CreateTime { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime UpdateTime { get; set; }
}
using LMIS.Modules.ReaderManage.LibraryCard;
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
    public string UserName { get; set; }
    public string CardLevelName { get; set; }
    public LibraryCardStatusEnum Status { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime CreateTime { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime UpdateTime { get; set; }
}
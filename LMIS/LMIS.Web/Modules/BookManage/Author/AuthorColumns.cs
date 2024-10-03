using LMIS.Modules.Common.Enums;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.BookManage.Columns;

[ColumnsScript("BookManage.Author")]
[BasedOnRow(typeof(AuthorRow), CheckNames = true)]
public class AuthorColumns
{
    [EditLink, AlignRight]
    public long AuthorId { get; set; }
    [EditLink]
    public string AuthorName { get; set; }
    public SexEnum Sex { get; set; }
    [Width(250)]
    public string Email { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime UpdateTime { get; set; }
}
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.BookManage.Columns;

[ColumnsScript("BookManage.Authors")]
[BasedOnRow(typeof(AuthorsRow), CheckNames = true)]
public class AuthorsColumns
{
    [EditLink, AlignRight]
    public long AuthorId { get; set; }
    [EditLink]
    public string AuthorName { get; set; }
    public short Sex { get; set; }
    public string Email { get; set; }
    public string AuthorImage { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime CreateTime { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime UpdateTime { get; set; }
}
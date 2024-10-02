using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.BookManage.Columns;

[ColumnsScript("BookManage.Publishers")]
[BasedOnRow(typeof(PublishersRow), CheckNames = true)]
public class PublishersColumns
{
    [EditLink, AlignRight]
    public long PublisherId { get; set; }
    [EditLink]
    public string PublisherName { get; set; }
    public string Contact { get; set; }
    public string ContactPhone { get; set; }
    public string Email { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime CreateTime { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime UpdateTime { get; set; }
}
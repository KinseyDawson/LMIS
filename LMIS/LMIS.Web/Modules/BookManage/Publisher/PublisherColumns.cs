using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.BookManage.Columns;

[ColumnsScript("BookManage.Publisher")]
[BasedOnRow(typeof(PublisherRow), CheckNames = true)]
public class PublisherColumns
{
    //[EditLink,AlignRight]
    //public long PublisherId { get; set; }
    [EditLink]
    public string PublisherName { get; set; }
    public string Contact { get; set; }
    public string ContactPhone { get; set; }
    [Width(250)]
    public string Email { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime UpdateTime { get; set; }
}
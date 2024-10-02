using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.BookManage.Columns;

[ColumnsScript("BookManage.Authors")]
[BasedOnRow(typeof(AuthorsRow), CheckNames = true)]
public class AuthorsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public long AuthorId { get; set; }
    [EditLink]
    public string AuthorName { get; set; }
    public short Sex { get; set; }
    public string Email { get; set; }
    public string AuthorImage { get; set; }
    public DateTime CreateTime { get; set; }
    public DateTime UpdateTime { get; set; }
}
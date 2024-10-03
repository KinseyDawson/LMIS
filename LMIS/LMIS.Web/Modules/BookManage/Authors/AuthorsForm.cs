using LMIS.Modules.Common.Enums;
using Serenity.ComponentModel;
using System;

namespace LMIS.BookManage.Forms;

[FormScript("BookManage.Authors")]
[BasedOnRow(typeof(AuthorsRow), CheckNames = true)]
public class AuthorsForm
{
    public string AuthorName { get; set; }
    public SexEnum Sex { get; set; }
    public string Email { get; set; }
    public string AuthorImage { get; set; }
}
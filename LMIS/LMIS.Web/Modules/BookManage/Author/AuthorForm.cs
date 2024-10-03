using LMIS.Modules.Common.Enums;
using Serenity.ComponentModel;
using System;

namespace LMIS.BookManage.Forms;

[FormScript("BookManage.Author")]
[BasedOnRow(typeof(AuthorRow), CheckNames = true)]
public class AuthorForm
{
    public string AuthorName { get; set; }
    public SexEnum Sex { get; set; }
    [EmailAddressEditor]
    public string Email { get; set; }
    public string AuthorImage { get; set; }
}
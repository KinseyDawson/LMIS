using Serenity.ComponentModel;
using System;

namespace LMIS.BookManage.Forms;

[FormScript("BookManage.Publisher")]
[BasedOnRow(typeof(PublisherRow), CheckNames = true)]
public class PublisherForm
{
    public string PublisherName { get; set; }
    public string Contact { get; set; }
    public string ContactPhone { get; set; }
    [EmailAddressEditor]
    public string Email { get; set; }
}
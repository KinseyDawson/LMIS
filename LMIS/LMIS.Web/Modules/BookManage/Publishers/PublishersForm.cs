using Serenity.ComponentModel;
using System;

namespace LMIS.BookManage.Forms;

[FormScript("BookManage.Publishers")]
[BasedOnRow(typeof(PublishersRow), CheckNames = true)]
public class PublishersForm
{
    public string PublisherName { get; set; }
    public string Contact { get; set; }
    public string ContactPhone { get; set; }
    public string Email { get; set; }
}
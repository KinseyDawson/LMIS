using Serenity.ComponentModel;
using System;

namespace LMIS.BookManage.Forms;

[FormScript("BookManage.Categories")]
[BasedOnRow(typeof(CategoriesRow), CheckNames = true)]
public class CategoriesForm
{
    public string CategoryName { get; set; }
}
namespace LMIS.Modules.BookManage;

[NestedPermissionKeys]
[DisplayName("BookManage")]
public class BookManagePermissionKeys
{
    [Description("Author")]
    public const string Author = "BookManage:Author";
    [Description("ReadBook")]
    public const string ReadBook = "BookManage:ReadBook";
    [Description("ModifyBook")]
    public const string ModifyBook = "BookManage:ModifyBook";
    [Description("Bookshelf")]
    public const string Bookshelf = "BookManage:Bookshelf";
    [Description("Category")]
    public const string Category = "BookManage:Category";
    [Description("Publisher")]
    public const string Publisher = "BookManage:Publisher";
}

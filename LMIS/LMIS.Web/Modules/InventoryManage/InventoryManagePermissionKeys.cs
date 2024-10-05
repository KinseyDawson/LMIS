namespace LMIS.Modules.InventoryManage;

[NestedPermissionKeys]
[DisplayName("InventoryManage")]
public class InventoryManagePermissionKeys
{
    [Description("BookStore")]
    public const string BookStore = "InventoryManage:BookStore";
    [Description("ReadUpBookshelf")]
    public const string ReadUpBookshelf = "InventoryManage:ReadUpBookshelf";
    [Description("ModifyUpBookshelf")]
    public const string ModifyUpBookshelf = "InventoryManage:ModifyUpBookshelf";
    [Description("ReadDownBookshelf")]
    public const string ReadDownBookshelf = "InventoryManage:ReadDownBookshelf";
    [Description("ModifyDownBookshelf")]
    public const string ModifyDownBookshelf = "InventoryManage:ModifyDownBookshelf";
}

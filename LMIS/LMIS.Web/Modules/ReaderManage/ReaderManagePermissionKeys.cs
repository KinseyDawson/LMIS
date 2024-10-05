namespace LMIS.Modules.ReaderManage;

[NestedPermissionKeys]
[DisplayName("ReaderManage")]
public class ReaderManagePermissionKeys
{
    [Description("ReadBorrow")]
    public const string ReadBorrow = "ReaderManage:ReadBorrow";
    [Description("ModifyBorrow")]
    public const string ModifyBorrow = "ReaderManage:ModifyBorrow";
    [Description("CardLevel")]
    public const string CardLevel = "ReaderManage:CardLevel";
    [Description("ReadLibraryCard")]
    public const string ReadLibraryCard = "ReaderManage:ReadLibraryCard";
    [Description("ModifyLibraryCard")]
    public const string ModifyLibraryCard = "ReaderManage:ModifyLibraryCard";
    [Description("UserBill")]
    public const string UserBill = "ReaderManage:UserBill";
}

using LMIS.Modules.ReaderManage;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace LMIS.ReaderManage;

[ConnectionKey("Default"), Module("ReaderManage"), TableName("userbills")]
[DisplayName("User Bill"), InstanceName("User Bill")]
[ReadPermission(ReaderManagePermissionKeys.UserBill)]
[ModifyPermission(ReaderManagePermissionKeys.UserBill)]
[ServiceLookupPermission("*")]
public sealed class UserBillRow : Row<UserBillRow.RowFields>, IIdRow
{
    const string jUser = nameof(jUser);

    [DisplayName("User Bill Id"), Identity, IdProperty]
    public long? UserBillId { get => fields.UserBillId[this]; set => fields.UserBillId[this] = value; }

    [DisplayName("User"), NotNull, ForeignKey(typeof(Administration.UserRow)), LeftJoin(jUser), TextualField(nameof(UserName))]
    [LookupEditor(typeof(Administration.UserRow), Async = true)]
    public long? UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Type"), NotNull]
    [QuickFilter]
    public short? Type { get => fields.Type[this]; set => fields.Type[this] = value; }

    [DisplayName("Fee"), Size(19), Scale(5), NotNull]
    public decimal? Fee { get => fields.Fee[this]; set => fields.Fee[this] = value; }

    [DisplayName("Remark"), Size(50)]
    public string Remark { get => fields.Remark[this]; set => fields.Remark[this] = value; }

    [DisplayName("Create Time"), NotNull]
    public DateTime? CreateTime { get => fields.CreateTime[this]; set => fields.CreateTime[this] = value; }

    [DisplayName("Update Time"), NotNull]
    public DateTime? UpdateTime { get => fields.UpdateTime[this]; set => fields.UpdateTime[this] = value; }

    [DisplayName("User Name"), Origin(jUser, nameof(Administration.UserRow.DisplayName)),QuickSearch]
    public string UserName { get => fields.UserName[this]; set => fields.UserName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int64Field UserBillId;
        public Int64Field UserId;
        public Int16Field Type;
        public DecimalField Fee;
        public StringField Remark;
        public DateTimeField CreateTime;
        public DateTimeField UpdateTime;

        public StringField UserName;
    }
}
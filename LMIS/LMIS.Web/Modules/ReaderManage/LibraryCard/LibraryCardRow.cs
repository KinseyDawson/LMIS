using LMIS.Modules.ReaderManage;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace LMIS.ReaderManage;

[ConnectionKey("Default"), Module("ReaderManage"), TableName("librarycards")]
[DisplayName("Library Card"), InstanceName("Library Card")]
[ReadPermission(ReaderManagePermissionKeys.ReadLibraryCard)]
[ModifyPermission(ReaderManagePermissionKeys.ModifyLibraryCard)]
[ServiceLookupPermission("*")]
public sealed class LibraryCardRow : Row<LibraryCardRow.RowFields>, IIdRow
{
    const string jUser = nameof(jUser);
    const string jLevel = nameof(jLevel);

    [DisplayName("Library Card Id"), Identity, IdProperty]
    public long? LibraryCardId { get => fields.LibraryCardId[this]; set => fields.LibraryCardId[this] = value; }

    [DisplayName("Library Card No"), Size(50), NotNull, QuickSearch,Updatable(false)]
    public string LibraryCardNo { get => fields.LibraryCardNo[this]; set => fields.LibraryCardNo[this] = value; }

    [DisplayName("User"), NotNull, ForeignKey(typeof(Administration.UserRow)), LeftJoin(jUser), TextualField(nameof(UserName))]
    [LookupEditor(typeof(Administration.UserRow), Async = true)]
    [Updatable(false)]
    public long? UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Level"), NotNull, ForeignKey(typeof(CardLevelRow)), LeftJoin(jLevel), TextualField(nameof(CardLevelName))]
    [ServiceLookupEditor(typeof(CardLevelRow))]
    public long? LevelId { get => fields.LevelId[this]; set => fields.LevelId[this] = value; }

    [DisplayName("Status"), NotNull,QuickFilter]
    [HideOnInsert]
    public short? Status { get => fields.Status[this]; set => fields.Status[this] = value; }

    [DisplayName("Create Time"), NotNull]
    public DateTime? CreateTime { get => fields.CreateTime[this]; set => fields.CreateTime[this] = value; }

    [DisplayName("Update Time"), NotNull]
    public DateTime? UpdateTime { get => fields.UpdateTime[this]; set => fields.UpdateTime[this] = value; }

    [DisplayName("User Name"), Origin(jUser, nameof(Administration.UserRow.DisplayName))]
    public string UserName { get => fields.UserName[this]; set => fields.UserName[this] = value; }

    [DisplayName("Card Level Name"), Origin(jLevel, nameof(CardLevelRow.CardLevelName))]
    public string CardLevelName { get => fields.CardLevelName[this]; set => fields.CardLevelName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int64Field LibraryCardId;
        public StringField LibraryCardNo;
        public Int64Field UserId;
        public Int64Field LevelId;
        public Int16Field Status;
        public DateTimeField CreateTime;
        public DateTimeField UpdateTime;

        public StringField UserName;
        public StringField CardLevelName;
    }
}
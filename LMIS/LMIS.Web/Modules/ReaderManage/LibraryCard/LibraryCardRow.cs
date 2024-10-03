using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace LMIS.ReaderManage;

[ConnectionKey("Default"), Module("ReaderManage"), TableName("librarycards")]
[DisplayName("Library Card"), InstanceName("Library Card")]
[ReadPermission("ReaderManage:LibraryCard")]
[ModifyPermission("ReaderManage:LibraryCard")]
[ServiceLookupPermission("ReaderManage:LibraryCard")]
public sealed class LibraryCardRow : Row<LibraryCardRow.RowFields>, IIdRow, INameRow
{
    const string jUser = nameof(jUser);
    const string jLevel = nameof(jLevel);

    [DisplayName("Library Card Id"), Identity, IdProperty]
    public long? LibraryCardId { get => fields.LibraryCardId[this]; set => fields.LibraryCardId[this] = value; }

    [DisplayName("Library Card No"), Size(50), NotNull, QuickSearch, NameProperty]
    public string LibraryCardNo { get => fields.LibraryCardNo[this]; set => fields.LibraryCardNo[this] = value; }

    [DisplayName("User"), NotNull, ForeignKey(typeof(Administration.UserRow)), LeftJoin(jUser), TextualField(nameof(Username))]
    [LookupEditor(typeof(Administration.UserRow), Async = true)]
    public long? UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Level"), NotNull, ForeignKey(typeof(CardLevelRow)), LeftJoin(jLevel), TextualField(nameof(LevelCardLevelName))]
    [ServiceLookupEditor(typeof(CardLevelRow))]
    public long? LevelId { get => fields.LevelId[this]; set => fields.LevelId[this] = value; }

    [DisplayName("Status"), NotNull]
    public short? Status { get => fields.Status[this]; set => fields.Status[this] = value; }

    [DisplayName("Create Time"), NotNull]
    public DateTime? CreateTime { get => fields.CreateTime[this]; set => fields.CreateTime[this] = value; }

    [DisplayName("Update Time"), NotNull]
    public DateTime? UpdateTime { get => fields.UpdateTime[this]; set => fields.UpdateTime[this] = value; }

    [DisplayName("User Username"), Origin(jUser, nameof(Administration.UserRow.Username))]
    public string Username { get => fields.Username[this]; set => fields.Username[this] = value; }

    [DisplayName("Level Card Level Name"), Origin(jLevel, nameof(CardLevelRow.CardLevelName))]
    public string LevelCardLevelName { get => fields.LevelCardLevelName[this]; set => fields.LevelCardLevelName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int64Field LibraryCardId;
        public StringField LibraryCardNo;
        public Int64Field UserId;
        public Int64Field LevelId;
        public Int16Field Status;
        public DateTimeField CreateTime;
        public DateTimeField UpdateTime;

        public StringField Username;
        public StringField LevelCardLevelName;
    }
}
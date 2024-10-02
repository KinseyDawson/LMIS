using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace LMIS.ReaderManage;

[ConnectionKey("Default"), Module("ReaderManage"), TableName("librarycardlose")]
[DisplayName("Library Card Lose"), InstanceName("Library Card Lose")]
[ReadPermission("LibraryCardLose")]
[ModifyPermission("LibraryCardLose")]
public sealed class LibraryCardLoseRow : Row<LibraryCardLoseRow.RowFields>, IIdRow
{
    const string jLibraryCard = nameof(jLibraryCard);
    const string jOperateUser = nameof(jOperateUser);

    [DisplayName("Library Card Lost Id"), Identity, IdProperty]
    public long? LibraryCardLostId { get => fields.LibraryCardLostId[this]; set => fields.LibraryCardLostId[this] = value; }

    [DisplayName("Library Card"), NotNull, ForeignKey(typeof(LibraryCardsRow)), LeftJoin(jLibraryCard), TextualField(nameof(LibraryCardNo))]
    [ServiceLookupEditor(typeof(LibraryCardsRow))]
    public long? LibraryCardId { get => fields.LibraryCardId[this]; set => fields.LibraryCardId[this] = value; }

    [DisplayName("Operate User"), NotNull, ForeignKey(typeof(Administration.UserRow)), LeftJoin(jOperateUser)]
    [TextualField(nameof(OperateUserUsername)), LookupEditor(typeof(Administration.UserRow), Async = true)]
    public long? OperateUserId { get => fields.OperateUserId[this]; set => fields.OperateUserId[this] = value; }

    [DisplayName("Create Time"), NotNull]
    public DateTime? CreateTime { get => fields.CreateTime[this]; set => fields.CreateTime[this] = value; }

    [DisplayName("Update Time"), NotNull]
    public DateTime? UpdateTime { get => fields.UpdateTime[this]; set => fields.UpdateTime[this] = value; }

    [DisplayName("Library Card Library Card No"), Origin(jLibraryCard, nameof(LibraryCardsRow.LibraryCardNo))]
    public string LibraryCardNo { get => fields.LibraryCardNo[this]; set => fields.LibraryCardNo[this] = value; }

    [DisplayName("Operate User Username"), Origin(jOperateUser, nameof(Administration.UserRow.Username))]
    public string OperateUserUsername { get => fields.OperateUserUsername[this]; set => fields.OperateUserUsername[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int64Field LibraryCardLostId;
        public Int64Field LibraryCardId;
        public Int64Field OperateUserId;
        public DateTimeField CreateTime;
        public DateTimeField UpdateTime;

        public StringField LibraryCardNo;
        public StringField OperateUserUsername;
    }
}
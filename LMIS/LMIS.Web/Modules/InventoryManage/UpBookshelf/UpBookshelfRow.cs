using LMIS.BookManage;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace LMIS.InventoryManage;

[ConnectionKey("Default"), Module("InventoryManage"), TableName("upbookshelfs")]
[DisplayName("Up Bookshelf"), InstanceName("Up Bookshelf")]
[ReadPermission("InventoryManage:UpBookshelf")]
[ModifyPermission("InventoryManage:UpBookshelf")]
public sealed class UpBookshelfRow : Row<UpBookshelfRow.RowFields>, IIdRow
{
    const string jBook = nameof(jBook);
    const string jBookshelf = nameof(jBookshelf);
    const string jOperateUser = nameof(jOperateUser);

    [DisplayName("Up Bookshelf Id"), Identity, IdProperty]
    public long? UpBookshelfId { get => fields.UpBookshelfId[this]; set => fields.UpBookshelfId[this] = value; }

    [DisplayName("Book"), NotNull, ForeignKey("books", "BookId"), LeftJoin(jBook), TextualField(nameof(BookName))]
    [ServiceLookupEditor(typeof(BookRow))]
    public long? BookId { get => fields.BookId[this]; set => fields.BookId[this] = value; }

    [DisplayName("Bookshelf"), NotNull, ForeignKey("bookshelfs", "BookshelfId"), LeftJoin(jBookshelf)]
    [TextualField(nameof(BookshelfLocation))]
    [ServiceLookupEditor(typeof(BookshelfRow))]
    public long? BookshelfId { get => fields.BookshelfId[this]; set => fields.BookshelfId[this] = value; }

    [DisplayName("Inventory"), NotNull]
    public long? Inventory { get => fields.Inventory[this]; set => fields.Inventory[this] = value; }

    [DisplayName("Operate User"), NotNull, ForeignKey(typeof(Administration.UserRow)), LeftJoin(jOperateUser)]
    [TextualField(nameof(OperateUserName)), LookupEditor(typeof(Administration.UserRow), Async = true)]
    public long? OperateUserId { get => fields.OperateUserId[this]; set => fields.OperateUserId[this] = value; }

    [DisplayName("Create Time"), NotNull]
    public DateTime? CreateTime { get => fields.CreateTime[this]; set => fields.CreateTime[this] = value; }

    [DisplayName("Update Time"), NotNull]
    public DateTime? UpdateTime { get => fields.UpdateTime[this]; set => fields.UpdateTime[this] = value; }

    [DisplayName("Book Name"), Expression($"{jBook}.[BookName]"),QuickSearch]
    public string BookName { get => fields.BookName[this]; set => fields.BookName[this] = value; }

    [DisplayName("Bookshelf Location"), Expression($"{jBookshelf}.[Location]")]
    public string BookshelfLocation { get => fields.BookshelfLocation[this]; set => fields.BookshelfLocation[this] = value; }

    [DisplayName("Operate UserName"), Origin(jOperateUser, nameof(Administration.UserRow.DisplayName))]
    public string OperateUserName { get => fields.OperateUserName[this]; set => fields.OperateUserName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int64Field UpBookshelfId;
        public Int64Field BookId;
        public Int64Field BookshelfId;
        public Int64Field Inventory;
        public Int64Field OperateUserId;
        public DateTimeField CreateTime;
        public DateTimeField UpdateTime;

        public StringField BookName;
        public StringField BookshelfLocation;
        public StringField OperateUserName;
    }
}
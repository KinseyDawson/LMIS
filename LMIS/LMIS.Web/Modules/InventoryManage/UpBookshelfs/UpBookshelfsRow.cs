using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace LMIS.InventoryManage;

[ConnectionKey("Default"), Module("InventoryManage"), TableName("upbookshelfs")]
[DisplayName("Up Bookshelfs"), InstanceName("Up Bookshelfs")]
[ReadPermission("UpBookshelfs")]
[ModifyPermission("UpBookshelfs")]
public sealed class UpBookshelfsRow : Row<UpBookshelfsRow.RowFields>, IIdRow
{
    const string jBook = nameof(jBook);
    const string jBookshelf = nameof(jBookshelf);
    const string jUser = nameof(jUser);

    [DisplayName("Up Bookshelf Id"), Identity, IdProperty]
    public long? UpBookshelfId { get => fields.UpBookshelfId[this]; set => fields.UpBookshelfId[this] = value; }

    [DisplayName("Book"), NotNull, ForeignKey(typeof(BookManage.BooksRow)), LeftJoin(jBook), TextualField(nameof(BookName))]
    [ServiceLookupEditor(typeof(BookManage.BooksRow), Service = "BookManage/Books/List")]
    public long? BookId { get => fields.BookId[this]; set => fields.BookId[this] = value; }

    [DisplayName("Bookshelf"), NotNull, ForeignKey(typeof(BookManage.BookshelfsRow)), LeftJoin(jBookshelf)]
    [TextualField(nameof(BookshelfLocation))]
    [ServiceLookupEditor(typeof(BookManage.BookshelfsRow), Service = "BookManage/Bookshelfs/List")]
    public long? BookshelfId { get => fields.BookshelfId[this]; set => fields.BookshelfId[this] = value; }

    [DisplayName("Inventory"), NotNull]
    public long? Inventory { get => fields.Inventory[this]; set => fields.Inventory[this] = value; }

    [DisplayName("User"), NotNull, ForeignKey(typeof(Administration.UserRow)), LeftJoin(jUser), TextualField(nameof(Username))]
    [LookupEditor(typeof(Administration.UserRow), Async = true)]
    public long? OperateUserId { get => fields.OperateUserId[this]; set => fields.OperateUserId[this] = value; }

    [DisplayName("Create Time"), NotNull]
    public DateTime? CreateTime { get => fields.CreateTime[this]; set => fields.CreateTime[this] = value; }

    [DisplayName("Update Time"), NotNull]
    public DateTime? UpdateTime { get => fields.UpdateTime[this]; set => fields.UpdateTime[this] = value; }

    [DisplayName("Book Book Name"), Origin(jBook, nameof(BookManage.BooksRow.BookName))]
    public string BookName { get => fields.BookName[this]; set => fields.BookName[this] = value; }

    [DisplayName("Bookshelf Location"), Origin(jBookshelf, nameof(BookManage.BookshelfsRow.Location))]
    public string BookshelfLocation { get => fields.BookshelfLocation[this]; set => fields.BookshelfLocation[this] = value; }

    [DisplayName("User Username"), Origin(jUser, nameof(Administration.UserRow.Username))]
    public string Username { get => fields.Username[this]; set => fields.Username[this] = value; }

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
        public StringField Username;
    }
}
using LMIS.Modules.InventoryManage;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace LMIS.InventoryManage;

[ConnectionKey("Default"), Module("InventoryManage"), TableName("bookstores")]
[DisplayName("Book Store"), InstanceName("Book Store")]
[ReadPermission(InventoryManagePermissionKeys.BookStore)]
[ModifyPermission(InventoryManagePermissionKeys.BookStore)]
public sealed class BookStoreRow : Row<BookStoreRow.RowFields>, IIdRow
{
    const string jBook = nameof(jBook);
    const string jBookshelf = nameof(jBookshelf);

    [DisplayName("Book Store Id"), Identity, IdProperty]
    public long? BookStoreId { get => fields.BookStoreId[this]; set => fields.BookStoreId[this] = value; }

    [DisplayName("Book"), NotNull, ForeignKey(typeof(BookManage.BookRow)), LeftJoin(jBook), TextualField(nameof(BookName))]
    [ServiceLookupEditor(typeof(BookManage.BookRow), Service = "BookManage/Book/List")]
    public long? BookId { get => fields.BookId[this]; set => fields.BookId[this] = value; }

    [DisplayName("Bookshelf"), NotNull, ForeignKey(typeof(BookManage.BookshelfRow)), LeftJoin(jBookshelf)]
    [TextualField(nameof(BookshelfLocation))]
    [ServiceLookupEditor(typeof(BookManage.BookshelfRow), Service = "BookManage/Bookshelf/List")]
    public long? BookshelfId { get => fields.BookshelfId[this]; set => fields.BookshelfId[this] = value; }

    [DisplayName("Inventory"), NotNull]
    public long? Inventory { get => fields.Inventory[this]; set => fields.Inventory[this] = value; }

    [DisplayName("Create Time"), NotNull]
    public DateTime? CreateTime { get => fields.CreateTime[this]; set => fields.CreateTime[this] = value; }

    [DisplayName("Update Time"), NotNull]
    public DateTime? UpdateTime { get => fields.UpdateTime[this]; set => fields.UpdateTime[this] = value; }

    [DisplayName("Book Name"), Origin(jBook, nameof(BookManage.BookRow.BookName)), QuickSearch]
    public string BookName { get => fields.BookName[this]; set => fields.BookName[this] = value; }

    [DisplayName("Bookshelf Location"), Origin(jBookshelf, nameof(BookManage.BookshelfRow.Location))]
    public string BookshelfLocation { get => fields.BookshelfLocation[this]; set => fields.BookshelfLocation[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int64Field BookStoreId;
        public Int64Field BookId;
        public Int64Field BookshelfId;
        public Int64Field Inventory;
        public DateTimeField CreateTime;
        public DateTimeField UpdateTime;

        public StringField BookName;
        public StringField BookshelfLocation;
    }
}
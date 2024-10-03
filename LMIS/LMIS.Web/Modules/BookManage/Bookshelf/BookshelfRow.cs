using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace LMIS.BookManage;

[ConnectionKey("Default"), Module("BookManage"), TableName("bookshelfs")]
[DisplayName("Bookshelf"), InstanceName("Bookshelf")]
[ReadPermission("BookManage:Bookshelf")]
[ModifyPermission("BookManage:Bookshelf")]
[ServiceLookupPermission("BookManage:Bookshelf")]
public sealed class BookshelfRow : Row<BookshelfRow.RowFields>, IIdRow, INameRow
{
    const string jCategory = nameof(jCategory);

    [DisplayName("Bookshelf Id"), Identity, IdProperty]
    public long? BookshelfId { get => fields.BookshelfId[this]; set => fields.BookshelfId[this] = value; }

    [DisplayName("Location"), Size(100), NotNull, QuickSearch, NameProperty]
    public string Location { get => fields.Location[this]; set => fields.Location[this] = value; }

    [DisplayName("Category"), NotNull, ForeignKey(typeof(CategoryRow)), LeftJoin(jCategory), TextualField(nameof(CategoryName))]
    [ServiceLookupEditor(typeof(CategoryRow))]
    public long? CategoryId { get => fields.CategoryId[this]; set => fields.CategoryId[this] = value; }

    [DisplayName("Bookshelf Image"), Size(100)]
    [ImageUploadEditor(FilenameFormat = "BookshelfImage/~", CopyToHistory = true)]
    public string BookshelfImage { get => fields.BookshelfImage[this]; set => fields.BookshelfImage[this] = value; }

    [DisplayName("Book Count"), NotNull,Size(4)]
    public long? BookCount { get => fields.BookCount[this]; set => fields.BookCount[this] = value; }

    [DisplayName("Book Capacity"), NotNull, Size(4)]
    public long? BookCapacity { get => fields.BookCapacity[this]; set => fields.BookCapacity[this] = value; }

    [DisplayName("Create Time"), NotNull]
    public DateTime? CreateTime { get => fields.CreateTime[this]; set => fields.CreateTime[this] = value; }

    [DisplayName("Update Time"), NotNull]
    public DateTime? UpdateTime { get => fields.UpdateTime[this]; set => fields.UpdateTime[this] = value; }

    [DisplayName("Category Name"), Origin(jCategory, nameof(CategoryRow.CategoryName))]
    public string CategoryName { get => fields.CategoryName[this]; set => fields.CategoryName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int64Field BookshelfId;
        public StringField Location;
        public Int64Field CategoryId;
        public StringField BookshelfImage;
        public Int64Field BookCount;
        public Int64Field BookCapacity;
        public DateTimeField CreateTime;
        public DateTimeField UpdateTime;

        public StringField CategoryName;
    }
}
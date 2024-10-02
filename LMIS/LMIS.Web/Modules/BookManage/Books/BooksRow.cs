using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace LMIS.BookManage;

[ConnectionKey("Default"), Module("BookManage"), TableName("books")]
[DisplayName("Books"), InstanceName("Books")]
[ReadPermission("Books")]
[ModifyPermission("Books")]
[ServiceLookupPermission("Books")]
public sealed class BooksRow : Row<BooksRow.RowFields>, IIdRow, INameRow
{
    const string jAuthor = nameof(jAuthor);
    const string jPublisher = nameof(jPublisher);

    [DisplayName("Book Id"), Identity, IdProperty]
    public long? BookId { get => fields.BookId[this]; set => fields.BookId[this] = value; }

    [DisplayName("Book Name"), Size(100), NotNull, QuickSearch, NameProperty]
    public string BookName { get => fields.BookName[this]; set => fields.BookName[this] = value; }

    [DisplayName("CN"), Size(20)]
    public string CN { get => fields.CN[this]; set => fields.CN[this] = value; }

    [DisplayName("ISSN"), Size(20)]
    public string ISSN { get => fields.ISSN[this]; set => fields.ISSN[this] = value; }

    [DisplayName("ISBN"), Size(20)]
    public string ISBN { get => fields.ISBN[this]; set => fields.ISBN[this] = value; }

    [DisplayName("Author"), NotNull, ForeignKey(typeof(AuthorsRow)), LeftJoin(jAuthor), TextualField(nameof(AuthorName))]
    [ServiceLookupEditor(typeof(AuthorsRow))]
    public long? AuthorId { get => fields.AuthorId[this]; set => fields.AuthorId[this] = value; }

    [DisplayName("Publisher"), NotNull, ForeignKey(typeof(PublishersRow)), LeftJoin(jPublisher), TextualField(nameof(PublisherName))]
    [ServiceLookupEditor(typeof(PublishersRow))]
    public long? PublisherId { get => fields.PublisherId[this]; set => fields.PublisherId[this] = value; }

    [DisplayName("Publishe Date"), NotNull]
    public DateTime? PublisheDate { get => fields.PublisheDate[this]; set => fields.PublisheDate[this] = value; }

    [DisplayName("Page"), NotNull]
    public int? Page { get => fields.Page[this]; set => fields.Page[this] = value; }

    [DisplayName("Price"), Size(19), Scale(5), NotNull]
    public decimal? Price { get => fields.Price[this]; set => fields.Price[this] = value; }

    [DisplayName("Inventory"), NotNull]
    public long? Inventory { get => fields.Inventory[this]; set => fields.Inventory[this] = value; }

    [DisplayName("Book Status"), NotNull]
    public short? BookStatus { get => fields.BookStatus[this]; set => fields.BookStatus[this] = value; }

    [DisplayName("Book Image"), Size(100)]
    public string BookImage { get => fields.BookImage[this]; set => fields.BookImage[this] = value; }

    [DisplayName("Create Time"), NotNull]
    public DateTime? CreateTime { get => fields.CreateTime[this]; set => fields.CreateTime[this] = value; }

    [DisplayName("Update Time"), NotNull]
    public DateTime? UpdateTime { get => fields.UpdateTime[this]; set => fields.UpdateTime[this] = value; }

    [DisplayName("Author Author Name"), Origin(jAuthor, nameof(AuthorsRow.AuthorName))]
    public string AuthorName { get => fields.AuthorName[this]; set => fields.AuthorName[this] = value; }

    [DisplayName("Publisher Publisher Name"), Origin(jPublisher, nameof(PublishersRow.PublisherName))]
    public string PublisherName { get => fields.PublisherName[this]; set => fields.PublisherName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int64Field BookId;
        public StringField BookName;
        public StringField CN;
        public StringField ISSN;
        public StringField ISBN;
        public Int64Field AuthorId;
        public Int64Field PublisherId;
        public DateTimeField PublisheDate;
        public Int32Field Page;
        public DecimalField Price;
        public Int64Field Inventory;
        public Int16Field BookStatus;
        public StringField BookImage;
        public DateTimeField CreateTime;
        public DateTimeField UpdateTime;

        public StringField AuthorName;
        public StringField PublisherName;
    }
}
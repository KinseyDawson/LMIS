using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace LMIS.BookManage;

[ConnectionKey("Default"), Module("BookManage"), TableName("publishers")]
[DisplayName("Publisher"), InstanceName("Publisher")]
[ReadPermission("BookManage:Publisher")]
[ModifyPermission("BookManage:Publisher")]
[ServiceLookupPermission("BookManage:Publisher")]
public sealed class PublisherRow : Row<PublisherRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Publisher Id"), Identity, IdProperty]
    public long? PublisherId { get => fields.PublisherId[this]; set => fields.PublisherId[this] = value; }

    [DisplayName("Publisher Name"), Size(100), NotNull, QuickSearch, NameProperty]
    public string PublisherName { get => fields.PublisherName[this]; set => fields.PublisherName[this] = value; }

    [DisplayName("Contact"), Size(10)]
    public string Contact { get => fields.Contact[this]; set => fields.Contact[this] = value; }

    [DisplayName("Contact Phone"), Size(20)]
    public string ContactPhone { get => fields.ContactPhone[this]; set => fields.ContactPhone[this] = value; }

    [DisplayName("Email"), Size(100)]
    public string Email { get => fields.Email[this]; set => fields.Email[this] = value; }

    [DisplayName("Create Time"), NotNull]
    public DateTime? CreateTime { get => fields.CreateTime[this]; set => fields.CreateTime[this] = value; }

    [DisplayName("Update Time"), NotNull]
    public DateTime? UpdateTime { get => fields.UpdateTime[this]; set => fields.UpdateTime[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int64Field PublisherId;
        public StringField PublisherName;
        public StringField Contact;
        public StringField ContactPhone;
        public StringField Email;
        public DateTimeField CreateTime;
        public DateTimeField UpdateTime;

    }
}
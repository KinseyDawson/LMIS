using LMIS.Modules.Common.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace LMIS.BookManage;

[ConnectionKey("Default"), Module("BookManage"), TableName("authors")]
[DisplayName("Authors"), InstanceName("Authors")]
[ReadPermission("Authors")]
[ModifyPermission("Authors")]
[ServiceLookupPermission("Authors")]
public sealed class AuthorsRow : Row<AuthorsRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Author Id"), Identity, IdProperty]
    public long? AuthorId { get => fields.AuthorId[this]; set => fields.AuthorId[this] = value; }

    [DisplayName("Author Name"), Size(100), NotNull, QuickSearch, NameProperty]
    public string AuthorName { get => fields.AuthorName[this]; set => fields.AuthorName[this] = value; }

    [DisplayName("Sex"), NotNull]
    public SexEnum? Sex { get => fields.Sex[this]; set => fields.Sex[this] = value; }

    [DisplayName("Email"), Size(100), NotNull]
    public string Email { get => fields.Email[this]; set => fields.Email[this] = value; }

    [DisplayName("Author Image"), Size(100)]
    [ImageUploadEditor(FilenameFormat = "AuthorImage/~", CopyToHistory = true)]
    public string AuthorImage { get => fields.AuthorImage[this]; set => fields.AuthorImage[this] = value; }

    [DisplayName("Create Time"), NotNull]
    public DateTime? CreateTime { get => fields.CreateTime[this]; set => fields.CreateTime[this] = value; }

    [DisplayName("Update Time"), NotNull]
    public DateTime? UpdateTime { get => fields.UpdateTime[this]; set => fields.UpdateTime[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int64Field AuthorId;
        public StringField AuthorName;
        public EnumField<SexEnum> Sex;
        public StringField Email;
        public StringField AuthorImage;
        public DateTimeField CreateTime;
        public DateTimeField UpdateTime;
    }
}
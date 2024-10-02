using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace LMIS.BookManage;

[ConnectionKey("Default"), Module("BookManage"), TableName("categories")]
[DisplayName("Categories"), InstanceName("Categories")]
[ReadPermission("Categories")]
[ModifyPermission("Categories")]
[ServiceLookupPermission("Categories")]
public sealed class CategoriesRow : Row<CategoriesRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Category Id"), Identity, IdProperty]
    public long? CategoryId { get => fields.CategoryId[this]; set => fields.CategoryId[this] = value; }

    [DisplayName("Category Name"), Size(50), NotNull, QuickSearch, NameProperty]
    public string CategoryName { get => fields.CategoryName[this]; set => fields.CategoryName[this] = value; }

    [DisplayName("Create Time"), NotNull]
    public DateTime? CreateTime { get => fields.CreateTime[this]; set => fields.CreateTime[this] = value; }

    [DisplayName("Update Time"), NotNull]
    public DateTime? UpdateTime { get => fields.UpdateTime[this]; set => fields.UpdateTime[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int64Field CategoryId;
        public StringField CategoryName;
        public DateTimeField CreateTime;
        public DateTimeField UpdateTime;

    }
}
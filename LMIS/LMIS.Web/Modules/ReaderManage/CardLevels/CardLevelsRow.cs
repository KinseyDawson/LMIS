﻿using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace LMIS.ReaderManage;

[ConnectionKey("Default"), Module("ReaderManage"), TableName("cardlevels")]
[DisplayName("Card Levels"), InstanceName("Card Levels")]
[ReadPermission("CardLevels")]
[ModifyPermission("CardLevels")]
[ServiceLookupPermission("CardLevels")]
public sealed class CardLevelsRow : Row<CardLevelsRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Card Level Id"), Identity, IdProperty]
    public long? CardLevelId { get => fields.CardLevelId[this]; set => fields.CardLevelId[this] = value; }

    [DisplayName("Card Level Name"), Size(50), NotNull, QuickSearch, NameProperty]
    public string CardLevelName { get => fields.CardLevelName[this]; set => fields.CardLevelName[this] = value; }

    [DisplayName("Discount"), Size(19), Scale(5), NotNull]
    public decimal? Discount { get => fields.Discount[this]; set => fields.Discount[this] = value; }

    [DisplayName("Penalty"), Size(19), Scale(5), NotNull]
    public decimal? Penalty { get => fields.Penalty[this]; set => fields.Penalty[this] = value; }

    [DisplayName("Borrow Days"), NotNull]
    public int? BorrowDays { get => fields.BorrowDays[this]; set => fields.BorrowDays[this] = value; }

    [DisplayName("Borrow Books"), NotNull]
    public int? BorrowBooks { get => fields.BorrowBooks[this]; set => fields.BorrowBooks[this] = value; }

    [DisplayName("Create Time"), NotNull]
    public DateTime? CreateTime { get => fields.CreateTime[this]; set => fields.CreateTime[this] = value; }

    [DisplayName("Update Time"), NotNull]
    public DateTime? UpdateTime { get => fields.UpdateTime[this]; set => fields.UpdateTime[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int64Field CardLevelId;
        public StringField CardLevelName;
        public DecimalField Discount;
        public DecimalField Penalty;
        public Int32Field BorrowDays;
        public Int32Field BorrowBooks;
        public DateTimeField CreateTime;
        public DateTimeField UpdateTime;

    }
}
using LMIS.Modules.ReaderManage.Borrow;
using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace LMIS.ReaderManage.Columns;

[ColumnsScript("ReaderManage.Borrow")]
[BasedOnRow(typeof(BorrowRow), CheckNames = true)]
public class BorrowColumns
{
    [EditLink, AlignRight]
    public long BorrowId { get; set; }
    [EditLink]
    [Width(200)]
    public string BorrowNo { get; set; }
    public string UserName { get; set; }
    public string BookName { get; set; }
    public string Location { get; set; }

    public BorrowStatusEnum BorrowStatus { get; set; }
    [Width(100)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd")]
    public DateTime BorrowDate { get; set; }
    [Width(100)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd")]
    public DateTime BorrowReturnDate { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime CreateTime { get; set; }
    [Width(150)]
    [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd HH:mm:ss")]
    public DateTime UpdateTime { get; set; }
}
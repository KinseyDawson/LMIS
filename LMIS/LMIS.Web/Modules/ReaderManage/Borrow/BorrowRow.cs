using LMIS.Modules.ReaderManage;

namespace LMIS.ReaderManage;

[ConnectionKey("Default"), Module("ReaderManage"), TableName("borrows")]
[DisplayName("Borrow"), InstanceName("Borrow")]
[ReadPermission(ReaderManagePermissionKeys.ReadBorrow)]
[ModifyPermission(ReaderManagePermissionKeys.ModifyBorrow)]
[ServiceLookupPermission("*")]
public sealed class BorrowRow : Row<BorrowRow.RowFields>, IIdRow, INameRow
{
    const string jUser = nameof(jUser);
    const string jBook = nameof(jBook);
    const string jBookshelf = nameof(jBookshelf);

    [DisplayName("Borrow Id"), Identity, IdProperty]
    public long? BorrowId { get => fields.BorrowId[this]; set => fields.BorrowId[this] = value; }

    [DisplayName("Borrow No"), Size(50), NotNull, QuickSearch, NameProperty]
    [Updatable(false)]
    public string BorrowNo { get => fields.BorrowNo[this]; set => fields.BorrowNo[this] = value; }

    [DisplayName("User"), NotNull, ForeignKey(typeof(Administration.UserRow)), LeftJoin(jUser), TextualField(nameof(UserName))]
    [LookupEditor(typeof(Administration.UserRow), Async = true)]
    [Updatable(false)]
    public long? UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Book"), NotNull, ForeignKey(typeof(BookManage.BookRow)), LeftJoin(jBook), TextualField(nameof(BookName))]
    [ServiceLookupEditor(typeof(BookManage.BookRow), Service = "BookManage/Book/List")]
    [Updatable(false)]
    public long? BookId { get => fields.BookId[this]; set => fields.BookId[this] = value; }



    [DisplayName("Bookshelf"), NotNull, ForeignKey(typeof(BookManage.BookshelfRow)), LeftJoin(jBookshelf), TextualField("Location")]
    [ServiceLookupEditor(typeof(BookManage.BookshelfRow), Service = "BookManage/Bookshelf/List")]
    [Updatable(false)]
    public long? BookshelfId { get => fields.BookshelfId[this]; set => fields.BookshelfId[this] = value; }

    [DisplayName("Borrow Status"), NotNull]
    [HideOnInsert]
    [QuickFilter]
    public short? BorrowStatus { get => fields.BorrowStatus[this]; set => fields.BorrowStatus[this] = value; }

    [DisplayName("Borrow Date"), NotNull]
    [Updatable(false)]
    public DateTime? BorrowDate { get => fields.BorrowDate[this]; set => fields.BorrowDate[this] = value; }

    [DisplayName("Borrow Return Date"), NotNull]
    [Updatable(false)]
    public DateTime? BorrowReturnDate { get => fields.BorrowReturnDate[this]; set => fields.BorrowReturnDate[this] = value; }

    [DisplayName("Create Time"), NotNull]
    public DateTime? CreateTime { get => fields.CreateTime[this]; set => fields.CreateTime[this] = value; }

    [DisplayName("Update Time"), NotNull]
    public DateTime? UpdateTime { get => fields.UpdateTime[this]; set => fields.UpdateTime[this] = value; }

    [DisplayName("User Name"), Origin(jUser, nameof(Administration.UserRow.DisplayName))]
    public string UserName { get => fields.UserName[this]; set => fields.UserName[this] = value; }

    [DisplayName("Book  Name"), Origin(jBook, nameof(BookManage.BookRow.BookName))]
    public string BookName { get => fields.BookName[this]; set => fields.BookName[this] = value; }


    [DisplayName("Location"), Origin(jBookshelf, nameof(BookManage.BookshelfRow.Location))]
    public string Location { get => fields.Location[this]; set => fields.Location[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int64Field BorrowId;
        public StringField BorrowNo;
        public Int64Field UserId;
        public Int64Field BookId;
        public Int64Field BookshelfId;
        public Int16Field BorrowStatus;
        public DateTimeField BorrowDate;
        public DateTimeField BorrowReturnDate;
        public DateTimeField CreateTime;
        public DateTimeField UpdateTime;

        public StringField UserName;
        public StringField BookName;
        public StringField Location;
    }
}
using FluentMigrator;

namespace LMIS.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20240904_0004)]
public class DefaultDB_20240904_0004_Borrow : AutoReversingMigration
{
    public override void Up()
    {
        this.CreateTableWithId64("Borrows", "BorrowId", s => s
        .WithColumn("BorrowNo").AsString(50).NotNullable().Unique("UK_Borrows_BorrowNo")
        .WithColumn("UserId").AsInt64().NotNullable()
        .ForeignKey("FK_Borrows_UserId", "Users", "UserId")
        .WithColumn("BookId").AsInt64().NotNullable()
        .ForeignKey("FK_Borrows_BookId", "Books", "BookId")
        .WithColumn("BorrowStatus").AsInt16().NotNullable()
        .WithColumn("BorrowDate").AsDate().NotNullable()
        .WithColumn("BorrowReturnDate").AsDate().NotNullable()
        .WithColumn("CreateTime").AsDateTime().NotNullable()
        .WithColumn("UpdateTime").AsDateTime().NotNullable());
    }
}

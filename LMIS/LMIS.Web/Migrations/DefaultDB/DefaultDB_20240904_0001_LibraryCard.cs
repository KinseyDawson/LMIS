using FluentMigrator;

namespace LMIS.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20240904_0001)]
public class DefaultDB_20240904_0001_LibraryCard : AutoReversingMigration
{
    public override void Up()
    {
        this.CreateTableWithId64("CardLevels", "CardLevelId", s => s
            .WithColumn("CardLevelName").AsString(50).NotNullable().Unique("UK_CardLevels_CardLevelName")
            .WithColumn("Discount").AsDecimal().NotNullable().WithDefaultValue(1)
            .WithColumn("Penalty").AsDecimal().NotNullable().WithDefaultValue(0)
            .WithColumn("BorrowDays").AsInt32().NotNullable().WithDefaultValue(0)
            .WithColumn("BorrowBooks").AsInt32().NotNullable().WithDefaultValue(0)
            .WithColumn("CreateTime").AsDateTime().NotNullable()
            .WithColumn("UpdateTime").AsDateTime().NotNullable());

        this.CreateTableWithId64("LibraryCards", "LibraryCardId", s => s
          .WithColumn("LibraryCardNo").AsString(50).NotNullable().Unique("UK_LibraryCards_LibraryCardNo")
          .WithColumn("UserId").AsInt64().NotNullable()
          .ForeignKey("FK_LibraryCards_UserId", "Users", "UserId")
          .WithColumn("LevelId").AsInt64().NotNullable()
          .ForeignKey("FK_LibraryCards_CardLevelId", "CardLevels", "CardLevelId")
          .WithColumn("Status").AsInt16().NotNullable()
          .WithColumn("CreateTime").AsDateTime().NotNullable()
          .WithColumn("UpdateTime").AsDateTime().NotNullable());

        this.CreateTableWithId64("LibraryCardLose", "LibraryCardLostId", s => s
          .WithColumn("LibraryCardId").AsInt64().NotNullable()
          .ForeignKey("FK_LibraryCardLose_LibraryCardId", "LibraryCards", "LibraryCardId")
          .WithColumn("OperateUserId").AsInt64().NotNullable()
          .ForeignKey("FK_LibraryCardLose_OperateUserId", "Users", "UserId")
          .WithColumn("CreateTime").AsDateTime().NotNullable()
          .WithColumn("UpdateTime").AsDateTime().NotNullable());

    }
}

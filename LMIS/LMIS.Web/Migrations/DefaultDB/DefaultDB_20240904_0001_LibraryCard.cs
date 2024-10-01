using FluentMigrator;

namespace LMIS.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20240904_0001)]
public class DefaultDB_20240904_0001_LibraryCard : AutoReversingMigration
{
    public override void Up()
    {
        this.CreateTableWithId64("CardLevels", "CardLevelId", s => s
            .WithColumn("Name").AsString(50).NotNullable()
            .WithColumn("Discount").AsDecimal().NotNullable().WithDefaultValue(1)
            .WithColumn("Penalty").AsDecimal().NotNullable().WithDefaultValue(0));

        this.CreateTableWithId64("LibraryCards", "LibraryCardId", s => s
          .WithColumn("CardNo").AsString(50).NotNullable()
          .WithColumn("UserId").AsInt64().NotNullable()
          .ForeignKey("FK_LibraryCards_UserId", "Users", "UserId")
          .WithColumn("LevelId").AsInt64().NotNullable()
          .ForeignKey("FK_LibraryCards_CardLevelId", "CardLevels", "CardLevelId")
          .WithColumn("Status").AsInt16().NotNullable()
          .WithColumn("CreateTime").AsDateTime().NotNullable()
          .WithColumn("UpdateTime").AsDateTime().NotNullable());
    }
}

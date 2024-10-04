using FluentMigrator;

namespace LMIS.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20240904_0003)]
public class DefaultDB_20240904_0003_Bill : AutoReversingMigration
{
    public override void Up()
    {
        this.CreateTableWithId64("UserBills", "UserBillId", s => s
        .WithColumn("UserId").AsInt64().NotNullable()
        .ForeignKey("FK_UserBills_UserId","Users", "UserId")
        .WithColumn("Type").AsInt64().NotNullable()
        .WithColumn("Fee").AsDecimal().NotNullable()
        .WithColumn("Remark").AsString(50).Nullable()
        .WithColumn("CreateTime").AsDateTime().NotNullable()
        .WithColumn("UpdateTime").AsDateTime().NotNullable());
    }
}

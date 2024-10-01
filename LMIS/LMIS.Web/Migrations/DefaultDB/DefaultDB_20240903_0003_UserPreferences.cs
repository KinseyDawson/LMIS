using FluentMigrator;

namespace LMIS.Migrations.DefaultDB;
[DefaultDB, MigrationKey(20240903_0003)]
public class DefaultDB_20240903_0003_UserPreferences : AutoReversingMigration
{
    public override void Up()
    {
        this.CreateTableWithId32("UserPreferences", "UserPreferenceId", s => s
            .WithColumn("UserId").AsInt64().NotNullable()
            .WithColumn("PreferenceType").AsString(100).NotNullable()
            .WithColumn("Name").AsString(200).NotNullable()
            .WithColumn("Value").AsString(int.MaxValue).Nullable());

        Create.Index("IX_UserPref_UID_PrefType_Name")
            .OnTable("UserPreferences")
            .OnColumn("UserId").Ascending()
            .OnColumn("PreferenceType").Ascending()
            .OnColumn("Name").Ascending()
            .WithOptions().Unique();
    }
}
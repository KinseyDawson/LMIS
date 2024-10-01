using FluentMigrator;

namespace LMIS.Migrations.DefaultDB;
[DefaultDB, MigrationKey(20240903_0001)]
public class DefaultDB_20240903_0001_Initial : AutoReversingMigration
{
    public override void Up()
    {
        this.CreateTableWithId32("Users", "UserId", s => s
            .WithColumn("Username").AsString(100).NotNullable().Unique("IX_Users_Username")
            .WithColumn("DisplayName").AsString(100).NotNullable()
            .WithColumn("Email").AsString(100).Nullable()
            .WithColumn("PasswordHash").AsString(86).NotNullable()
            .WithColumn("PasswordSalt").AsString(10).NotNullable()
            .WithColumn("LastDirectoryUpdate").AsDateTime().Nullable()
            .WithColumn("UserImage").AsString(100).Nullable()
            .WithColumn("InsertDate").AsDateTime().NotNullable()
            .WithColumn("InsertUserId").AsInt32().NotNullable()
            .WithColumn("UpdateDate").AsDateTime().Nullable()
            .WithColumn("UpdateUserId").AsInt32().Nullable()
            .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));
        Insert.IntoTable("Users").Row(new
        {
            Username = "admin",
            DisplayName = "admin",
            Email = "admin@domain" + Serenity.IO.TemporaryFileHelper.RandomFileCode() + ".com",
            PasswordHash = "rfqpSPYs0ekFlPyvIRTXsdhE/qrTHFF+kKsAUla7pFkXL4BgLGlTe89GDX5DBysenMDj8AqbIZPybqvusyCjwQ",
            PasswordSalt = "hJf_F",
            InsertDate = new DateTime(2014, 1, 1),
            InsertUserId = 1,
            IsActive = 1
        });
        this.CreateTableWithId32("Languages", "Id", s => s
            .WithColumn("LanguageId").AsString(10).NotNullable().Unique("IX_Languages_LanguageId")
            .WithColumn("LanguageName").AsString(50).NotNullable());

        Insert.IntoTable("Languages").Row(new
        {
            LanguageId = "en",
            LanguageName = "English"
        });
        Insert.IntoTable("Languages").Row(new
        {
            LanguageId = "zh-CN",
            LanguageName = "Chinese (Simplified)"
        });
    }
}
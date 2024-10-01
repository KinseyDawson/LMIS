using FluentMigrator;

namespace LMIS.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20240904_0002)]
public class DefaultDB_20240904_0002_Book : AutoReversingMigration
{
    public override void Up()
    {
        this.CreateTableWithId64("Categories", "CategoryId", s => s
            .WithColumn("CategoryName").AsString(50).NotNullable().Unique("UK_Categories_CategoryName")
            .WithColumn("CreateTime").AsDateTime().NotNullable()
            .WithColumn("UpdateTime").AsDateTime().NotNullable());
        this.CreateTableWithId64("Bookshelfs", "BookshelfId", s => s
          .WithColumn("Location").AsString(100).NotNullable()
          .WithColumn("CategoryId").AsInt64().NotNullable()
          .ForeignKey("FK_Bookshelfs_CategoryId", "Categories", "CategoryId")
          .WithColumn("BookshelfImage").AsString(100).Nullable()
          .WithColumn("CreateTime").AsDateTime().NotNullable()
          .WithColumn("UpdateTime").AsDateTime().NotNullable());

        this.CreateTableWithId64("Authors", "AuthorId", s => s
          .WithColumn("AuthorName").AsString(100).NotNullable()
          .WithColumn("Sex").AsInt16().NotNullable()
          .WithColumn("Email").AsString(100).NotNullable()
          .WithColumn("AuthorImage").AsString(100).Nullable()
          .WithColumn("CreateTime").AsDateTime().NotNullable()
          .WithColumn("UpdateTime").AsDateTime().NotNullable());
        this.Create.UniqueConstraint("UK_Authors_AuthorName_Email")
            .OnTable("Authors")
            .Columns("AuthorName", "Email");

        this.CreateTableWithId64("Publishers", "PublisherId", s => s
          .WithColumn("PublisherName").AsString(100).NotNullable().Unique("UK_Publishers_PublisherName")
          .WithColumn("Contact").AsString(10).Nullable()
          .WithColumn("ContactPhone").AsString(20).Nullable()
          .WithColumn("Email").AsString(100).Nullable()
          .WithColumn("CreateTime").AsDateTime().NotNullable()
          .WithColumn("UpdateTime").AsDateTime().NotNullable());

        this.CreateTableWithId64("Books", "BookId", s => s
          .WithColumn("BookName").AsString(100).NotNullable()
          .WithColumn("CN").AsString(20).Nullable()
          .WithColumn("ISSN").AsString(20).Nullable()
          .WithColumn("ISBN").AsString(20).Nullable()
          .WithColumn("AuthorId").AsInt64().NotNullable()
          .ForeignKey("FK_Books_AuthorId", "Authors", "AuthorId")
          .WithColumn("PublisherId").AsInt64().NotNullable()
          .ForeignKey("FK_Books_PublisherId", "Publishers", "PublisherId")
          .WithColumn("Inventory").AsInt64().NotNullable()
          .WithColumn("BookImage").AsString(100).Nullable()
          .WithColumn("CreateTime").AsDateTime().NotNullable()
          .WithColumn("UpdateTime").AsDateTime().NotNullable());
    }
}

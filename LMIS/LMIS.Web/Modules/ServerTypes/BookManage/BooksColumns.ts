import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { BooksRow } from "./BooksRow";

export interface BooksColumns {
    BookId: Column<BooksRow>;
    BookName: Column<BooksRow>;
    CN: Column<BooksRow>;
    ISSN: Column<BooksRow>;
    ISBN: Column<BooksRow>;
    AuthorName: Column<BooksRow>;
    PublisherName: Column<BooksRow>;
    PublisheDate: Column<BooksRow>;
    Page: Column<BooksRow>;
    Price: Column<BooksRow>;
    Inventory: Column<BooksRow>;
    BookStatus: Column<BooksRow>;
    BookImage: Column<BooksRow>;
    CreateTime: Column<BooksRow>;
    UpdateTime: Column<BooksRow>;
}

export class BooksColumns extends ColumnsBase<BooksRow> {
    static readonly columnsKey = 'BookManage.Books';
    static readonly Fields = fieldsProxy<BooksColumns>();
}
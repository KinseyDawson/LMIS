import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { BookRow } from "./BookRow";

export interface BookColumns {
    BookId: Column<BookRow>;
    BookName: Column<BookRow>;
    Cn: Column<BookRow>;
    Issn: Column<BookRow>;
    Isbn: Column<BookRow>;
    AuthorName: Column<BookRow>;
    PublisherName: Column<BookRow>;
    PublisheDate: Column<BookRow>;
    Page: Column<BookRow>;
    Price: Column<BookRow>;
    Inventory: Column<BookRow>;
    BookStatus: Column<BookRow>;
    BookImage: Column<BookRow>;
    CreateTime: Column<BookRow>;
    UpdateTime: Column<BookRow>;
}

export class BookColumns extends ColumnsBase<BookRow> {
    static readonly columnsKey = 'BookManage.Book';
    static readonly Fields = fieldsProxy<BookColumns>();
}
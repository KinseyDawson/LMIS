import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { BookStatusEnum } from "../Modules/BookManage.Book.BookStatusEnum";
import { BookRow } from "./BookRow";

export interface BookColumns {
    BookId: Column<BookRow>;
    BookName: Column<BookRow>;
    CN: Column<BookRow>;
    ISSN: Column<BookRow>;
    ISBN: Column<BookRow>;
    AuthorName: Column<BookRow>;
    PublisherName: Column<BookRow>;
    PublisheDate: Column<BookRow>;
    Page: Column<BookRow>;
    Price: Column<BookRow>;
    Inventory: Column<BookRow>;
    BorrowableInventory: Column<BookRow>;
    BookStatus: Column<BookRow>;
    UpdateTime: Column<BookRow>;
}

export class BookColumns extends ColumnsBase<BookRow> {
    static readonly columnsKey = 'BookManage.Book';
    static readonly Fields = fieldsProxy<BookColumns>();
}

[BookStatusEnum]; // referenced types
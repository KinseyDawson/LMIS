import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { BookshelfRow } from "./BookshelfRow";

export interface BookshelfColumns {
    Location: Column<BookshelfRow>;
    CategoryName: Column<BookshelfRow>;
    BookCount: Column<BookshelfRow>;
    BookCapacity: Column<BookshelfRow>;
    UpdateTime: Column<BookshelfRow>;
}

export class BookshelfColumns extends ColumnsBase<BookshelfRow> {
    static readonly columnsKey = 'BookManage.Bookshelf';
    static readonly Fields = fieldsProxy<BookshelfColumns>();
}
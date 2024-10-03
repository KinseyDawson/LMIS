import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { BookshelfRow } from "./BookshelfRow";

export interface BookshelfColumns {
    BookshelfId: Column<BookshelfRow>;
    Location: Column<BookshelfRow>;
    CategoryName: Column<BookshelfRow>;
    BookshelfImage: Column<BookshelfRow>;
    BookCount: Column<BookshelfRow>;
    BookCapacity: Column<BookshelfRow>;
    CreateTime: Column<BookshelfRow>;
    UpdateTime: Column<BookshelfRow>;
}

export class BookshelfColumns extends ColumnsBase<BookshelfRow> {
    static readonly columnsKey = 'BookManage.Bookshelf';
    static readonly Fields = fieldsProxy<BookshelfColumns>();
}
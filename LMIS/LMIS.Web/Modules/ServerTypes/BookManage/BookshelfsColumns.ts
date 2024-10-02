import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { BookshelfsRow } from "./BookshelfsRow";

export interface BookshelfsColumns {
    BookshelfId: Column<BookshelfsRow>;
    Location: Column<BookshelfsRow>;
    CategoryName: Column<BookshelfsRow>;
    BookshelfImage: Column<BookshelfsRow>;
    BookCount: Column<BookshelfsRow>;
    BookCapacity: Column<BookshelfsRow>;
    CreateTime: Column<BookshelfsRow>;
    UpdateTime: Column<BookshelfsRow>;
}

export class BookshelfsColumns extends ColumnsBase<BookshelfsRow> {
    static readonly columnsKey = 'BookManage.Bookshelfs';
    static readonly Fields = fieldsProxy<BookshelfsColumns>();
}
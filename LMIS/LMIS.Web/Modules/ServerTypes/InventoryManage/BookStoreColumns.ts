import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { BookStoreRow } from "./BookStoreRow";

export interface BookStoreColumns {
    BookStoreId: Column<BookStoreRow>;
    BookName: Column<BookStoreRow>;
    BookshelfLocation: Column<BookStoreRow>;
    Inventory: Column<BookStoreRow>;
    CreateTime: Column<BookStoreRow>;
    UpdateTime: Column<BookStoreRow>;
}

export class BookStoreColumns extends ColumnsBase<BookStoreRow> {
    static readonly columnsKey = 'InventoryManage.BookStore';
    static readonly Fields = fieldsProxy<BookStoreColumns>();
}
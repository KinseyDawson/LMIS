import { fieldsProxy } from "@serenity-is/corelib";

export interface BookStoreRow {
    BookStoreId?: number;
    BookId?: number;
    BookshelfId?: number;
    Inventory?: number;
    CreateTime?: string;
    UpdateTime?: string;
    BookName?: string;
    BookshelfLocation?: string;
}

export abstract class BookStoreRow {
    static readonly idProperty = 'BookStoreId';
    static readonly localTextPrefix = 'InventoryManage.BookStore';
    static readonly deletePermission = 'InventoryManage:BookStore';
    static readonly insertPermission = 'InventoryManage:BookStore';
    static readonly readPermission = 'InventoryManage:BookStore';
    static readonly updatePermission = 'InventoryManage:BookStore';

    static readonly Fields = fieldsProxy<BookStoreRow>();
}
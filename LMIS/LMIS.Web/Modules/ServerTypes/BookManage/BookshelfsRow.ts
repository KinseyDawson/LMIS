import { fieldsProxy } from "@serenity-is/corelib";

export interface BookshelfsRow {
    BookshelfId?: number;
    Location?: string;
    CategoryId?: number;
    BookshelfImage?: string;
    BookCount?: number;
    BookCapacity?: number;
    CreateTime?: string;
    UpdateTime?: string;
    CategoryName?: string;
}

export abstract class BookshelfsRow {
    static readonly idProperty = 'BookshelfId';
    static readonly nameProperty = 'Location';
    static readonly localTextPrefix = 'BookManage.Bookshelfs';
    static readonly deletePermission = 'Books';
    static readonly insertPermission = 'Books';
    static readonly readPermission = 'Books';
    static readonly updatePermission = 'Books';

    static readonly Fields = fieldsProxy<BookshelfsRow>();
}
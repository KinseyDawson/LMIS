import { fieldsProxy } from "@serenity-is/corelib";

export interface BookshelfRow {
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

export abstract class BookshelfRow {
    static readonly idProperty = 'BookshelfId';
    static readonly nameProperty = 'Location';
    static readonly localTextPrefix = 'BookManage.Bookshelf';
    static readonly deletePermission = 'BookManage:Bookshelf';
    static readonly insertPermission = 'BookManage:Bookshelf';
    static readonly readPermission = 'BookManage:Bookshelf';
    static readonly updatePermission = 'BookManage:Bookshelf';

    static readonly Fields = fieldsProxy<BookshelfRow>();
}
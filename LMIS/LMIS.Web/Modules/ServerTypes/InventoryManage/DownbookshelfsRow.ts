import { fieldsProxy } from "@serenity-is/corelib";

export interface DownBookshelfsRow {
    DownBookshelfId?: number;
    BookId?: number;
    BookshelfId?: number;
    OperateUserId?: number;
    CreateTime?: string;
    UpdateTime?: string;
    BookName?: string;
    BookshelfLocation?: string;
    Username?: string;
}

export abstract class DownBookshelfsRow {
    static readonly idProperty = 'DownBookshelfId';
    static readonly localTextPrefix = 'InventoryManage.DownBookshelfs';
    static readonly deletePermission = 'DownBookshelfs';
    static readonly insertPermission = 'DownBookshelfs';
    static readonly readPermission = 'DownBookshelfs';
    static readonly updatePermission = 'DownBookshelfs';

    static readonly Fields = fieldsProxy<DownBookshelfsRow>();
}
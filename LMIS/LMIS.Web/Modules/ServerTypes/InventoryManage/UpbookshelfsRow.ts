import { fieldsProxy } from "@serenity-is/corelib";

export interface UpBookshelfsRow {
    UpBookshelfId?: number;
    BookId?: number;
    BookshelfId?: number;
    Inventory?: number;
    OperateUserId?: number;
    CreateTime?: string;
    UpdateTime?: string;
    BookName?: string;
    BookshelfLocation?: string;
    Username?: string;
}

export abstract class UpBookshelfsRow {
    static readonly idProperty = 'UpBookshelfId';
    static readonly localTextPrefix = 'InventoryManage.UpBookshelfs';
    static readonly deletePermission = 'UpBookshelfs';
    static readonly insertPermission = 'UpBookshelfs';
    static readonly readPermission = 'UpBookshelfs';
    static readonly updatePermission = 'UpBookshelfs';

    static readonly Fields = fieldsProxy<UpBookshelfsRow>();
}
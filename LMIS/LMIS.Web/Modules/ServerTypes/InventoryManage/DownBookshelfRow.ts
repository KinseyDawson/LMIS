import { fieldsProxy } from "@serenity-is/corelib";

export interface DownBookshelfRow {
    DownBookshelfId?: number;
    BookId?: number;
    BookshelfId?: number;
    OperateUserId?: number;
    CreateTime?: string;
    UpdateTime?: string;
    BookName?: string;
    BookshelfLocation?: string;
    OperateUserName?: string;
}

export abstract class DownBookshelfRow {
    static readonly idProperty = 'DownBookshelfId';
    static readonly localTextPrefix = 'InventoryManage.DownBookshelf';
    static readonly deletePermission = 'InventoryManage:DownBookshelf';
    static readonly insertPermission = 'InventoryManage:DownBookshelf';
    static readonly readPermission = 'InventoryManage:DownBookshelf';
    static readonly updatePermission = 'InventoryManage:DownBookshelf';

    static readonly Fields = fieldsProxy<DownBookshelfRow>();
}
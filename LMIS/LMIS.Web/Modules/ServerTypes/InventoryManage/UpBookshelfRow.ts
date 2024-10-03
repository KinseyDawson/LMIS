import { fieldsProxy } from "@serenity-is/corelib";

export interface UpBookshelfRow {
    UpBookshelfId?: number;
    BookId?: number;
    BookshelfId?: number;
    Inventory?: number;
    OperateUserId?: number;
    CreateTime?: string;
    UpdateTime?: string;
    BookName?: string;
    BookshelfLocation?: string;
    OperateUserUsername?: string;
}

export abstract class UpBookshelfRow {
    static readonly idProperty = 'UpBookshelfId';
    static readonly localTextPrefix = 'InventoryManage.UpBookshelf';
    static readonly deletePermission = 'InventoryManage:UpBookshelf';
    static readonly insertPermission = 'InventoryManage:UpBookshelf';
    static readonly readPermission = 'InventoryManage:UpBookshelf';
    static readonly updatePermission = 'InventoryManage:UpBookshelf';

    static readonly Fields = fieldsProxy<UpBookshelfRow>();
}
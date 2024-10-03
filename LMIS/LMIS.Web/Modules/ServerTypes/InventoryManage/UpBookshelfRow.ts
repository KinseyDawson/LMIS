import { fieldsProxy } from "@serenity-is/corelib";

export interface UpBookshelfRow {
    UpBookshelfId?: number;
    BookId?: number;
    BookshelfId?: number;
    Inventory?: number;
    OperateUserId?: number;
    Remark?: string;
    CreateTime?: string;
    UpdateTime?: string;
    BookName?: string;
    BookshelfLocation?: string;
    OperateUserName?: string;
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
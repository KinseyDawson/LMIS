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
    static readonly deletePermission = 'InventoryManage:ModifyUpBookshelf';
    static readonly insertPermission = 'InventoryManage:ModifyUpBookshelf';
    static readonly readPermission = 'InventoryManage:ReadUpBookshelf';
    static readonly updatePermission = 'InventoryManage:ModifyUpBookshelf';

    static readonly Fields = fieldsProxy<UpBookshelfRow>();
}
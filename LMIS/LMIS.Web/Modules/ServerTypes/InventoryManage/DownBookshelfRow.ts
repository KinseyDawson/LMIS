import { fieldsProxy } from "@serenity-is/corelib";

export interface DownBookshelfRow {
    DownBookshelfId?: number;
    BookId?: number;
    BookshelfId?: number;
    OperateUserId?: number;
    Inventory?: number;
    Remark?: string;
    CreateTime?: string;
    UpdateTime?: string;
    BookName?: string;
    BookshelfLocation?: string;
    OperateUserName?: string;
}

export abstract class DownBookshelfRow {
    static readonly idProperty = 'DownBookshelfId';
    static readonly localTextPrefix = 'InventoryManage.DownBookshelf';
    static readonly deletePermission = 'InventoryManage:ModifyDownBookshelf';
    static readonly insertPermission = 'InventoryManage:ModifyDownBookshelf';
    static readonly readPermission = 'InventoryManage:ReadDownBookshelf';
    static readonly updatePermission = 'InventoryManage:ModifyDownBookshelf';

    static readonly Fields = fieldsProxy<DownBookshelfRow>();
}
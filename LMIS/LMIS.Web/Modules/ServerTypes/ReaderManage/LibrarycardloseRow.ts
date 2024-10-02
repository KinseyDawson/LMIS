import { fieldsProxy } from "@serenity-is/corelib";

export interface LibraryCardLoseRow {
    LibraryCardLostId?: number;
    LibraryCardId?: number;
    OperateUserId?: number;
    CreateTime?: string;
    UpdateTime?: string;
    LibraryCardNo?: string;
    OperateUserUsername?: string;
}

export abstract class LibraryCardLoseRow {
    static readonly idProperty = 'LibraryCardLostId';
    static readonly localTextPrefix = 'ReaderManage.LibraryCardLose';
    static readonly deletePermission = 'LibraryCardLose';
    static readonly insertPermission = 'LibraryCardLose';
    static readonly readPermission = 'LibraryCardLose';
    static readonly updatePermission = 'LibraryCardLose';

    static readonly Fields = fieldsProxy<LibraryCardLoseRow>();
}
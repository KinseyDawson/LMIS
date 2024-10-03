import { fieldsProxy } from "@serenity-is/corelib";

export interface LibraryCardLoseRow {
    LibraryCardLoseId?: number;
    LibraryCardId?: number;
    OperateUserId?: number;
    CreateTime?: string;
    UpdateTime?: string;
    LibraryCardNo?: string;
    OperateUserUsername?: string;
}

export abstract class LibraryCardLoseRow {
    static readonly idProperty = 'LibraryCardLoseId';
    static readonly localTextPrefix = 'ReaderManage.LibraryCardLose';
    static readonly deletePermission = 'ReaderManage:LibraryCardLose';
    static readonly insertPermission = 'ReaderManage:LibraryCardLose';
    static readonly readPermission = 'ReaderManage:LibraryCardLose';
    static readonly updatePermission = 'ReaderManage:LibraryCardLose';

    static readonly Fields = fieldsProxy<LibraryCardLoseRow>();
}
import { fieldsProxy } from "@serenity-is/corelib";

export interface LibraryCardRow {
    LibraryCardId?: number;
    LibraryCardNo?: string;
    UserId?: number;
    LevelId?: number;
    Status?: number;
    CreateTime?: string;
    UpdateTime?: string;
    UserName?: string;
    CardLevelName?: string;
}

export abstract class LibraryCardRow {
    static readonly idProperty = 'LibraryCardId';
    static readonly localTextPrefix = 'ReaderManage.LibraryCard';
    static readonly deletePermission = 'ReaderManage:ModifyLibraryCard';
    static readonly insertPermission = 'ReaderManage:ModifyLibraryCard';
    static readonly readPermission = 'ReaderManage:ReadLibraryCard';
    static readonly updatePermission = 'ReaderManage:ModifyLibraryCard';

    static readonly Fields = fieldsProxy<LibraryCardRow>();
}
import { fieldsProxy } from "@serenity-is/corelib";

export interface LibraryCardRow {
    LibraryCardId?: number;
    LibraryCardNo?: string;
    UserId?: number;
    LevelId?: number;
    Status?: number;
    CreateTime?: string;
    UpdateTime?: string;
    Username?: string;
    LevelCardLevelName?: string;
}

export abstract class LibraryCardRow {
    static readonly idProperty = 'LibraryCardId';
    static readonly nameProperty = 'LibraryCardNo';
    static readonly localTextPrefix = 'ReaderManage.LibraryCard';
    static readonly deletePermission = 'ReaderManage:LibraryCard';
    static readonly insertPermission = 'ReaderManage:LibraryCard';
    static readonly readPermission = 'ReaderManage:LibraryCard';
    static readonly updatePermission = 'ReaderManage:LibraryCard';

    static readonly Fields = fieldsProxy<LibraryCardRow>();
}
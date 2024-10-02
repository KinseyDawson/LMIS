import { fieldsProxy } from "@serenity-is/corelib";

export interface LibraryCardsRow {
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

export abstract class LibraryCardsRow {
    static readonly idProperty = 'LibraryCardId';
    static readonly nameProperty = 'LibraryCardNo';
    static readonly localTextPrefix = 'ReaderManage.LibraryCards';
    static readonly deletePermission = 'LibraryCards';
    static readonly insertPermission = 'LibraryCards';
    static readonly readPermission = 'LibraryCards';
    static readonly updatePermission = 'LibraryCards';

    static readonly Fields = fieldsProxy<LibraryCardsRow>();
}
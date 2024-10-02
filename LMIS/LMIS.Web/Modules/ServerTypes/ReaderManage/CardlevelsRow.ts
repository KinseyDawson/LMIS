import { fieldsProxy } from "@serenity-is/corelib";

export interface CardLevelsRow {
    CardLevelId?: number;
    CardLevelName?: string;
    Discount?: number;
    Penalty?: number;
    BorrowDays?: number;
    BorrowBooks?: number;
    CreateTime?: string;
    UpdateTime?: string;
}

export abstract class CardLevelsRow {
    static readonly idProperty = 'CardLevelId';
    static readonly nameProperty = 'CardLevelName';
    static readonly localTextPrefix = 'ReaderManage.CardLevels';
    static readonly deletePermission = 'CardLevels';
    static readonly insertPermission = 'CardLevels';
    static readonly readPermission = 'CardLevels';
    static readonly updatePermission = 'CardLevels';

    static readonly Fields = fieldsProxy<CardLevelsRow>();
}
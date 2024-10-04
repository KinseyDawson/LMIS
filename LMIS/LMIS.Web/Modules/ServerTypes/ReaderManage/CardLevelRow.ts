import { fieldsProxy } from "@serenity-is/corelib";

export interface CardLevelRow {
    CardLevelId?: number;
    CardLevelName?: string;
    Fee?: number;
    Rent?: number;
    Discount?: number;
    Penalty?: number;
    BorrowDays?: number;
    BorrowBooks?: number;
    CreateTime?: string;
    UpdateTime?: string;
}

export abstract class CardLevelRow {
    static readonly idProperty = 'CardLevelId';
    static readonly nameProperty = 'CardLevelName';
    static readonly localTextPrefix = 'ReaderManage.CardLevel';
    static readonly deletePermission = 'ReaderManage:CardLevel';
    static readonly insertPermission = 'ReaderManage:CardLevel';
    static readonly readPermission = 'ReaderManage:CardLevel';
    static readonly updatePermission = 'ReaderManage:CardLevel';

    static readonly Fields = fieldsProxy<CardLevelRow>();
}
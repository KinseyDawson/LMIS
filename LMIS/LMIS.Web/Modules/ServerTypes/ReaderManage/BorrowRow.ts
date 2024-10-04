import { fieldsProxy } from "@serenity-is/corelib";

export interface BorrowRow {
    BorrowId?: number;
    BorrowNo?: string;
    UserId?: number;
    BookId?: number;
    BorrowStatus?: number;
    BorrowDate?: string;
    BorrowReturnDate?: string;
    CreateTime?: string;
    UpdateTime?: string;
    UserName?: string;
    BookName?: string;
}

export abstract class BorrowRow {
    static readonly idProperty = 'BorrowId';
    static readonly nameProperty = 'BorrowNo';
    static readonly localTextPrefix = 'ReaderManage.Borrow';
    static readonly deletePermission = 'ReaderManage:Borrow';
    static readonly insertPermission = 'ReaderManage:Borrow';
    static readonly readPermission = 'ReaderManage:Borrow';
    static readonly updatePermission = 'ReaderManage:Borrow';

    static readonly Fields = fieldsProxy<BorrowRow>();
}
import { fieldsProxy } from "@serenity-is/corelib";

export interface BorrowRow {
    BorrowId?: number;
    BorrowNo?: string;
    UserId?: number;
    BookId?: number;
    BookshelfId?: number;
    BorrowStatus?: number;
    BorrowDate?: string;
    BorrowReturnDate?: string;
    CreateTime?: string;
    UpdateTime?: string;
    UserName?: string;
    BookName?: string;
    Location?: string;
}

export abstract class BorrowRow {
    static readonly idProperty = 'BorrowId';
    static readonly nameProperty = 'BorrowNo';
    static readonly localTextPrefix = 'ReaderManage.Borrow';
    static readonly deletePermission = 'ReaderManage:ModifyBorrow';
    static readonly insertPermission = 'ReaderManage:ModifyBorrow';
    static readonly readPermission = 'ReaderManage:ReadBorrow';
    static readonly updatePermission = 'ReaderManage:ModifyBorrow';

    static readonly Fields = fieldsProxy<BorrowRow>();
}
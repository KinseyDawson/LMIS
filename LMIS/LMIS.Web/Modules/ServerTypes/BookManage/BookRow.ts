import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface BookRow {
    BookId?: number;
    BookName?: string;
    CN?: string;
    ISSN?: string;
    ISBN?: string;
    AuthorId?: number;
    PublisherId?: number;
    PublisheDate?: string;
    Page?: number;
    Price?: number;
    Inventory?: number;
    BorrowableInventory?: number;
    BookStatus?: number;
    BookImage?: string;
    CreateTime?: string;
    UpdateTime?: string;
    AuthorName?: string;
    PublisherName?: string;
}

export abstract class BookRow {
    static readonly idProperty = 'BookId';
    static readonly nameProperty = 'BookName';
    static readonly localTextPrefix = 'BookManage.Book';
    static readonly lookupKey = 'BookManage.Book';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<BookRow>('BookManage.Book') }
    static async getLookupAsync() { return getLookupAsync<BookRow>('BookManage.Book') }

    static readonly deletePermission = 'BookManage:ModifyBook';
    static readonly insertPermission = 'BookManage:ModifyBook';
    static readonly readPermission = 'BookManage:ReadBook';
    static readonly updatePermission = 'BookManage:ModifyBook';

    static readonly Fields = fieldsProxy<BookRow>();
}
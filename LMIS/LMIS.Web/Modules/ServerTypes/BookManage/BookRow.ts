import { fieldsProxy } from "@serenity-is/corelib";

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
    static readonly deletePermission = 'BookManage:Book';
    static readonly insertPermission = 'BookManage:Book';
    static readonly readPermission = 'BookManage:Book';
    static readonly updatePermission = 'BookManage:Book';

    static readonly Fields = fieldsProxy<BookRow>();
}
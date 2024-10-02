import { fieldsProxy } from "@serenity-is/corelib";

export interface BooksRow {
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
    BookStatus?: number;
    BookImage?: string;
    CreateTime?: string;
    UpdateTime?: string;
    AuthorName?: string;
    PublisherName?: string;
}

export abstract class BooksRow {
    static readonly idProperty = 'BookId';
    static readonly nameProperty = 'BookName';
    static readonly localTextPrefix = 'BookManage.Books';
    static readonly deletePermission = 'Books';
    static readonly insertPermission = 'Books';
    static readonly readPermission = 'Books';
    static readonly updatePermission = 'Books';

    static readonly Fields = fieldsProxy<BooksRow>();
}
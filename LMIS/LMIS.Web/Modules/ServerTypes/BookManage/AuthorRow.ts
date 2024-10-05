import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface AuthorRow {
    AuthorId?: number;
    AuthorName?: string;
    Sex?: number;
    Email?: string;
    AuthorImage?: string;
    CreateTime?: string;
    UpdateTime?: string;
}

export abstract class AuthorRow {
    static readonly idProperty = 'AuthorId';
    static readonly nameProperty = 'AuthorName';
    static readonly localTextPrefix = 'BookManage.Author';
    static readonly lookupKey = 'BookManage.Author';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<AuthorRow>('BookManage.Author') }
    static async getLookupAsync() { return getLookupAsync<AuthorRow>('BookManage.Author') }

    static readonly deletePermission = 'BookManage:Author';
    static readonly insertPermission = 'BookManage:Author';
    static readonly readPermission = 'BookManage:Author';
    static readonly updatePermission = 'BookManage:Author';

    static readonly Fields = fieldsProxy<AuthorRow>();
}
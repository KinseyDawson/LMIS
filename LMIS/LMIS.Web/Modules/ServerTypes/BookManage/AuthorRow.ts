import { fieldsProxy } from "@serenity-is/corelib";

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
    static readonly deletePermission = 'BookManage:Author';
    static readonly insertPermission = 'BookManage:Author';
    static readonly readPermission = 'BookManage:Author';
    static readonly updatePermission = 'BookManage:Author';

    static readonly Fields = fieldsProxy<AuthorRow>();
}
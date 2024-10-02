﻿import { fieldsProxy } from "@serenity-is/corelib";

export interface AuthorsRow {
    AuthorId?: number;
    AuthorName?: string;
    Sex?: number;
    Email?: string;
    AuthorImage?: string;
    CreateTime?: string;
    UpdateTime?: string;
}

export abstract class AuthorsRow {
    static readonly idProperty = 'AuthorId';
    static readonly nameProperty = 'AuthorName';
    static readonly localTextPrefix = 'BookManage.Authors';
    static readonly deletePermission = 'Authors';
    static readonly insertPermission = 'Authors';
    static readonly readPermission = 'Authors';
    static readonly updatePermission = 'Authors';

    static readonly Fields = fieldsProxy<AuthorsRow>();
}
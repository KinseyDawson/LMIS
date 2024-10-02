import { fieldsProxy } from "@serenity-is/corelib";

export interface CategoriesRow {
    CategoryId?: number;
    CategoryName?: string;
    CreateTime?: string;
    UpdateTime?: string;
}

export abstract class CategoriesRow {
    static readonly idProperty = 'CategoryId';
    static readonly nameProperty = 'CategoryName';
    static readonly localTextPrefix = 'BookManage.Categories';
    static readonly deletePermission = 'Categories';
    static readonly insertPermission = 'Categories';
    static readonly readPermission = 'Categories';
    static readonly updatePermission = 'Categories';

    static readonly Fields = fieldsProxy<CategoriesRow>();
}
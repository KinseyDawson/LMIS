import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface CategoryRow {
    CategoryId?: number;
    CategoryName?: string;
    CreateTime?: string;
    UpdateTime?: string;
}

export abstract class CategoryRow {
    static readonly idProperty = 'CategoryId';
    static readonly nameProperty = 'CategoryName';
    static readonly localTextPrefix = 'BookManage.Category';
    static readonly lookupKey = 'BookManage.Category';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<CategoryRow>('BookManage.Category') }
    static async getLookupAsync() { return getLookupAsync<CategoryRow>('BookManage.Category') }

    static readonly deletePermission = 'BookManage:Category';
    static readonly insertPermission = 'BookManage:Category';
    static readonly readPermission = 'BookManage:Category';
    static readonly updatePermission = 'BookManage:Category';

    static readonly Fields = fieldsProxy<CategoryRow>();
}
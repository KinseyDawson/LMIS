import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface PublisherRow {
    PublisherId?: number;
    PublisherName?: string;
    Contact?: string;
    ContactPhone?: string;
    Email?: string;
    CreateTime?: string;
    UpdateTime?: string;
}

export abstract class PublisherRow {
    static readonly idProperty = 'PublisherId';
    static readonly nameProperty = 'PublisherName';
    static readonly localTextPrefix = 'BookManage.Publisher';
    static readonly lookupKey = 'BookManage.Publisher';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<PublisherRow>('BookManage.Publisher') }
    static async getLookupAsync() { return getLookupAsync<PublisherRow>('BookManage.Publisher') }

    static readonly deletePermission = 'BookManage:Publisher';
    static readonly insertPermission = 'BookManage:Publisher';
    static readonly readPermission = 'BookManage:Publisher';
    static readonly updatePermission = 'BookManage:Publisher';

    static readonly Fields = fieldsProxy<PublisherRow>();
}
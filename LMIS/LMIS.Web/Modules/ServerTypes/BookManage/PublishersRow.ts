import { fieldsProxy } from "@serenity-is/corelib";

export interface PublishersRow {
    PublisherId?: number;
    PublisherName?: string;
    Contact?: string;
    ContactPhone?: string;
    Email?: string;
    CreateTime?: string;
    UpdateTime?: string;
}

export abstract class PublishersRow {
    static readonly idProperty = 'PublisherId';
    static readonly nameProperty = 'PublisherName';
    static readonly localTextPrefix = 'BookManage.Publishers';
    static readonly deletePermission = 'Publishers';
    static readonly insertPermission = 'Publishers';
    static readonly readPermission = 'Publishers';
    static readonly updatePermission = 'Publishers';

    static readonly Fields = fieldsProxy<PublishersRow>();
}
import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface LanguageRow {
    Id?: number;
    LanguageId?: string;
    LanguageName?: string;
}

export abstract class LanguageRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'LanguageName';
    static readonly localTextPrefix = 'Administration.Language';
    static readonly lookupKey = 'Administration.Language';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<LanguageRow>('Administration.Language') }
    static async getLookupAsync() { return getLookupAsync<LanguageRow>('Administration.Language') }

    static readonly deletePermission = '*';
    static readonly insertPermission = '*';
    static readonly readPermission = '*';
    static readonly updatePermission = '*';

    static readonly Fields = fieldsProxy<LanguageRow>();
}
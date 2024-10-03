import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { PublisherRow } from "./PublisherRow";

export interface PublisherColumns {
    PublisherId: Column<PublisherRow>;
    PublisherName: Column<PublisherRow>;
    Contact: Column<PublisherRow>;
    ContactPhone: Column<PublisherRow>;
    Email: Column<PublisherRow>;
    UpdateTime: Column<PublisherRow>;
}

export class PublisherColumns extends ColumnsBase<PublisherRow> {
    static readonly columnsKey = 'BookManage.Publisher';
    static readonly Fields = fieldsProxy<PublisherColumns>();
}
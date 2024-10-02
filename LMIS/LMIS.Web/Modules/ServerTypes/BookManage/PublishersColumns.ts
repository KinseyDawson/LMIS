import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { PublishersRow } from "./PublishersRow";

export interface PublishersColumns {
    PublisherId: Column<PublishersRow>;
    PublisherName: Column<PublishersRow>;
    Contact: Column<PublishersRow>;
    ContactPhone: Column<PublishersRow>;
    Email: Column<PublishersRow>;
    CreateTime: Column<PublishersRow>;
    UpdateTime: Column<PublishersRow>;
}

export class PublishersColumns extends ColumnsBase<PublishersRow> {
    static readonly columnsKey = 'BookManage.Publishers';
    static readonly Fields = fieldsProxy<PublishersColumns>();
}
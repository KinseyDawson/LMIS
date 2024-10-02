import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { DownBookshelfsRow } from "./DownBookshelfsRow";

export interface DownBookshelfsColumns {
    DownBookshelfId: Column<DownBookshelfsRow>;
    BookName: Column<DownBookshelfsRow>;
    BookshelfLocation: Column<DownBookshelfsRow>;
    OperateUserName: Column<DownBookshelfsRow>;
    CreateTime: Column<DownBookshelfsRow>;
    UpdateTime: Column<DownBookshelfsRow>;
}

export class DownBookshelfsColumns extends ColumnsBase<DownBookshelfsRow> {
    static readonly columnsKey = 'InventoryManage.DownBookshelfs';
    static readonly Fields = fieldsProxy<DownBookshelfsColumns>();
}
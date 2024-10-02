import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { UpBookshelfsRow } from "./UpBookshelfsRow";

export interface UpBookshelfsColumns {
    UpBookshelfId: Column<UpBookshelfsRow>;
    BookName: Column<UpBookshelfsRow>;
    BookshelfLocation: Column<UpBookshelfsRow>;
    Inventory: Column<UpBookshelfsRow>;
    OperateUserName: Column<UpBookshelfsRow>;
    CreateTime: Column<UpBookshelfsRow>;
    UpdateTime: Column<UpBookshelfsRow>;
}

export class UpBookshelfsColumns extends ColumnsBase<UpBookshelfsRow> {
    static readonly columnsKey = 'InventoryManage.UpBookshelfs';
    static readonly Fields = fieldsProxy<UpBookshelfsColumns>();
}
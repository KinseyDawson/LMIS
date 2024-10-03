import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { DownBookshelfRow } from "./DownBookshelfRow";

export interface DownBookshelfColumns {
    DownBookshelfId: Column<DownBookshelfRow>;
    BookName: Column<DownBookshelfRow>;
    BookshelfLocation: Column<DownBookshelfRow>;
    Inventory: Column<DownBookshelfRow>;
    OperateUserName: Column<DownBookshelfRow>;
    Remark: Column<DownBookshelfRow>;
    CreateTime: Column<DownBookshelfRow>;
    UpdateTime: Column<DownBookshelfRow>;
}

export class DownBookshelfColumns extends ColumnsBase<DownBookshelfRow> {
    static readonly columnsKey = 'InventoryManage.DownBookshelf';
    static readonly Fields = fieldsProxy<DownBookshelfColumns>();
}
import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { UpBookshelfRow } from "./UpBookshelfRow";

export interface UpBookshelfColumns {
    UpBookshelfId: Column<UpBookshelfRow>;
    BookName: Column<UpBookshelfRow>;
    BookshelfLocation: Column<UpBookshelfRow>;
    Inventory: Column<UpBookshelfRow>;
    OperateUserName: Column<UpBookshelfRow>;
    Remark: Column<UpBookshelfRow>;
    CreateTime: Column<UpBookshelfRow>;
    UpdateTime: Column<UpBookshelfRow>;
}

export class UpBookshelfColumns extends ColumnsBase<UpBookshelfRow> {
    static readonly columnsKey = 'InventoryManage.UpBookshelf';
    static readonly Fields = fieldsProxy<UpBookshelfColumns>();
}
import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { CategoryRow } from "./CategoryRow";

export interface CategoryColumns {
    CategoryName: Column<CategoryRow>;
    UpdateTime: Column<CategoryRow>;
}

export class CategoryColumns extends ColumnsBase<CategoryRow> {
    static readonly columnsKey = 'BookManage.Category';
    static readonly Fields = fieldsProxy<CategoryColumns>();
}
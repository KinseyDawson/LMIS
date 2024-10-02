import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { CardLevelsRow } from "./CardLevelsRow";

export interface CardLevelsColumns {
    CardLevelId: Column<CardLevelsRow>;
    CardLevelName: Column<CardLevelsRow>;
    Discount: Column<CardLevelsRow>;
    Penalty: Column<CardLevelsRow>;
    BorrowDays: Column<CardLevelsRow>;
    BorrowBooks: Column<CardLevelsRow>;
    CreateTime: Column<CardLevelsRow>;
    UpdateTime: Column<CardLevelsRow>;
}

export class CardLevelsColumns extends ColumnsBase<CardLevelsRow> {
    static readonly columnsKey = 'ReaderManage.CardLevels';
    static readonly Fields = fieldsProxy<CardLevelsColumns>();
}
import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { CardLevelRow } from "./CardLevelRow";

export interface CardLevelColumns {
    CardLevelId: Column<CardLevelRow>;
    CardLevelName: Column<CardLevelRow>;
    Discount: Column<CardLevelRow>;
    Penalty: Column<CardLevelRow>;
    BorrowDays: Column<CardLevelRow>;
    BorrowBooks: Column<CardLevelRow>;
    CreateTime: Column<CardLevelRow>;
    UpdateTime: Column<CardLevelRow>;
}

export class CardLevelColumns extends ColumnsBase<CardLevelRow> {
    static readonly columnsKey = 'ReaderManage.CardLevel';
    static readonly Fields = fieldsProxy<CardLevelColumns>();
}
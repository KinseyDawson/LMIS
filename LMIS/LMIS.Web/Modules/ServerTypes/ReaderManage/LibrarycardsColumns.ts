import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { LibraryCardsRow } from "./LibraryCardsRow";

export interface LibraryCardsColumns {
    LibraryCardId: Column<LibraryCardsRow>;
    LibraryCardNo: Column<LibraryCardsRow>;
    Username: Column<LibraryCardsRow>;
    LevelCardLevelName: Column<LibraryCardsRow>;
    Status: Column<LibraryCardsRow>;
    CreateTime: Column<LibraryCardsRow>;
    UpdateTime: Column<LibraryCardsRow>;
}

export class LibraryCardsColumns extends ColumnsBase<LibraryCardsRow> {
    static readonly columnsKey = 'ReaderManage.LibraryCards';
    static readonly Fields = fieldsProxy<LibraryCardsColumns>();
}
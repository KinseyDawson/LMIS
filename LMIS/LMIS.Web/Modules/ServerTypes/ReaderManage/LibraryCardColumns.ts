import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { LibraryCardRow } from "./LibraryCardRow";

export interface LibraryCardColumns {
    LibraryCardId: Column<LibraryCardRow>;
    LibraryCardNo: Column<LibraryCardRow>;
    Username: Column<LibraryCardRow>;
    LevelCardLevelName: Column<LibraryCardRow>;
    Status: Column<LibraryCardRow>;
    CreateTime: Column<LibraryCardRow>;
    UpdateTime: Column<LibraryCardRow>;
}

export class LibraryCardColumns extends ColumnsBase<LibraryCardRow> {
    static readonly columnsKey = 'ReaderManage.LibraryCard';
    static readonly Fields = fieldsProxy<LibraryCardColumns>();
}
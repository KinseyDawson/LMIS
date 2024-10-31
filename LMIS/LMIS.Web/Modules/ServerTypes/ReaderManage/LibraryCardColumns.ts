import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { LibraryCardStatusEnum } from "../Modules/ReaderManage.LibraryCard.LibraryCardStatusEnum";
import { LibraryCardRow } from "./LibraryCardRow";

export interface LibraryCardColumns {
    LibraryCardNo: Column<LibraryCardRow>;
    UserName: Column<LibraryCardRow>;
    CardLevelName: Column<LibraryCardRow>;
    Status: Column<LibraryCardRow>;
    CreateTime: Column<LibraryCardRow>;
    UpdateTime: Column<LibraryCardRow>;
}

export class LibraryCardColumns extends ColumnsBase<LibraryCardRow> {
    static readonly columnsKey = 'ReaderManage.LibraryCard';
    static readonly Fields = fieldsProxy<LibraryCardColumns>();
}

[LibraryCardStatusEnum]; // referenced types
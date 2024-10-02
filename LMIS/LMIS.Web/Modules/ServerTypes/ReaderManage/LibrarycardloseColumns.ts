import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { LibraryCardLoseRow } from "./LibraryCardLoseRow";

export interface LibraryCardLoseColumns {
    LibraryCardLostId: Column<LibraryCardLoseRow>;
    LibraryCardNo: Column<LibraryCardLoseRow>;
    OperateUserUsername: Column<LibraryCardLoseRow>;
    CreateTime: Column<LibraryCardLoseRow>;
    UpdateTime: Column<LibraryCardLoseRow>;
}

export class LibraryCardLoseColumns extends ColumnsBase<LibraryCardLoseRow> {
    static readonly columnsKey = 'ReaderManage.LibraryCardLose';
    static readonly Fields = fieldsProxy<LibraryCardLoseColumns>();
}
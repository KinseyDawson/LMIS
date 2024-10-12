import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { BorrowStatusEnum } from "../Modules/ReaderManage.Borrow.BorrowStatusEnum";
import { BorrowRow } from "./BorrowRow";

export interface BorrowColumns {
    BorrowId: Column<BorrowRow>;
    BorrowNo: Column<BorrowRow>;
    UserName: Column<BorrowRow>;
    BookName: Column<BorrowRow>;
    Location: Column<BorrowRow>;
    BorrowStatus: Column<BorrowRow>;
    BorrowDate: Column<BorrowRow>;
    BorrowReturnDate: Column<BorrowRow>;
    CreateTime: Column<BorrowRow>;
    UpdateTime: Column<BorrowRow>;
}

export class BorrowColumns extends ColumnsBase<BorrowRow> {
    static readonly columnsKey = 'ReaderManage.Borrow';
    static readonly Fields = fieldsProxy<BorrowColumns>();
}

[BorrowStatusEnum]; // referenced types
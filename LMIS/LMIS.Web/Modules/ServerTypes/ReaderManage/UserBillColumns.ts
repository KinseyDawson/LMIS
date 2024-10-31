import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { BillTypeEnum } from "../Modules/ReaderManage.UserBill.BillTypeEnum";
import { UserBillRow } from "./UserBillRow";

export interface UserBillColumns {
    UserName: Column<UserBillRow>;
    Type: Column<UserBillRow>;
    Fee: Column<UserBillRow>;
    Remark: Column<UserBillRow>;
    UpdateTime: Column<UserBillRow>;
}

export class UserBillColumns extends ColumnsBase<UserBillRow> {
    static readonly columnsKey = 'ReaderManage.UserBill';
    static readonly Fields = fieldsProxy<UserBillColumns>();
}

[BillTypeEnum]; // referenced types
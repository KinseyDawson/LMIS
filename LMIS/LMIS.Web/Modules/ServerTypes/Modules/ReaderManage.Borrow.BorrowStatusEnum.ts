import { Decorators } from "@serenity-is/corelib";

export enum BorrowStatusEnum {
    Borrowed = 1,
    Returned = 2,
    ExpiredAndReturned = 3,
    Damaged = 4
}
Decorators.registerEnumType(BorrowStatusEnum, 'LMIS.Modules.ReaderManage.Borrow.BorrowStatusEnum');
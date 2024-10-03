import { Decorators } from "@serenity-is/corelib";

export enum BookStatusEnum {
    Borrowable = 1,
    Unborrowable = 2
}
Decorators.registerEnumType(BookStatusEnum, 'LMIS.Modules.BookManage.Book.BookStatusEnum');
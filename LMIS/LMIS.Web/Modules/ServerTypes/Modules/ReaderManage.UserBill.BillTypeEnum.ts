import { Decorators } from "@serenity-is/corelib";

export enum BillTypeEnum {
    Card = 1,
    CardUpLevel = 2,
    BookRent = 3,
    ExpireedPenalty = 4,
    BookCompensation = 5
}
Decorators.registerEnumType(BillTypeEnum, 'LMIS.Modules.ReaderManage.UserBill.BillTypeEnum');
import { Decorators } from "@serenity-is/corelib";

export enum BillTypeEnum {
    Card = 1,
    AppCard = 2,
    CardUpLevel = 3
}
Decorators.registerEnumType(BillTypeEnum, 'LMIS.Modules.ReaderManage.UserBill.BillTypeEnum');
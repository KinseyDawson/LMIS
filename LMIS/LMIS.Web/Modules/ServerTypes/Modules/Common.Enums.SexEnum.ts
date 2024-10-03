import { Decorators } from "@serenity-is/corelib";

export enum SexEnum {
    Male = 1,
    Female = 2
}
Decorators.registerEnumType(SexEnum, 'LMIS.Modules.Common.Enums.SexEnum');
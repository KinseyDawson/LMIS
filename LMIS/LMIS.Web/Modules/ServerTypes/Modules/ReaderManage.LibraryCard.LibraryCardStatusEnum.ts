import { Decorators } from "@serenity-is/corelib";

export enum LibraryCardStatusEnum {
    Normal = 1,
    Lose = 2
}
Decorators.registerEnumType(LibraryCardStatusEnum, 'LMIS.Modules.ReaderManage.LibraryCard.LibraryCardStatusEnum');
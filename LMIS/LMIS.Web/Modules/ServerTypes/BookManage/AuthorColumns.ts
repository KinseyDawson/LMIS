import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { SexEnum } from "../Modules/Common.Enums.SexEnum";
import { AuthorRow } from "./AuthorRow";

export interface AuthorColumns {
    AuthorId: Column<AuthorRow>;
    AuthorName: Column<AuthorRow>;
    Sex: Column<AuthorRow>;
    Email: Column<AuthorRow>;
    AuthorImage: Column<AuthorRow>;
    CreateTime: Column<AuthorRow>;
    UpdateTime: Column<AuthorRow>;
}

export class AuthorColumns extends ColumnsBase<AuthorRow> {
    static readonly columnsKey = 'BookManage.Author';
    static readonly Fields = fieldsProxy<AuthorColumns>();
}

[SexEnum]; // referenced types
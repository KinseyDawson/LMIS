import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { AuthorsRow } from "./AuthorsRow";

export interface AuthorsColumns {
    AuthorId: Column<AuthorsRow>;
    AuthorName: Column<AuthorsRow>;
    Sex: Column<AuthorsRow>;
    Email: Column<AuthorsRow>;
    AuthorImage: Column<AuthorsRow>;
    CreateTime: Column<AuthorsRow>;
    UpdateTime: Column<AuthorsRow>;
}

export class AuthorsColumns extends ColumnsBase<AuthorsRow> {
    static readonly columnsKey = 'BookManage.Authors';
    static readonly Fields = fieldsProxy<AuthorsColumns>();
}
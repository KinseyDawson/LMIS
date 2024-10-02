import { AuthorsColumns, AuthorsRow, AuthorsService } from '@/ServerTypes/BookManage';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AuthorsDialog } from './AuthorsDialog';

@Decorators.registerClass('LMIS.BookManage.AuthorsGrid')
export class AuthorsGrid extends EntityGrid<AuthorsRow> {
    protected getColumnsKey() { return AuthorsColumns.columnsKey; }
    protected getDialogType() { return AuthorsDialog; }
    protected getRowDefinition() { return AuthorsRow; }
    protected getService() { return AuthorsService.baseUrl; }
}
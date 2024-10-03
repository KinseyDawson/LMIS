import { AuthorColumns, AuthorRow, AuthorService } from '@/ServerTypes/BookManage';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AuthorDialog } from './AuthorDialog';

@Decorators.registerClass('LMIS.BookManage.AuthorGrid')
export class AuthorGrid extends EntityGrid<AuthorRow> {
    protected getColumnsKey() { return AuthorColumns.columnsKey; }
    protected getDialogType() { return AuthorDialog; }
    protected getRowDefinition() { return AuthorRow; }
    protected getService() { return AuthorService.baseUrl; }
}
import { BookshelfsColumns, BookshelfsRow, BookshelfsService } from '@/ServerTypes/BookManage';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { BookshelfsDialog } from './BookshelfsDialog';

@Decorators.registerClass('LMIS.BookManage.BookshelfsGrid')
export class BookshelfsGrid extends EntityGrid<BookshelfsRow> {
    protected getColumnsKey() { return BookshelfsColumns.columnsKey; }
    protected getDialogType() { return BookshelfsDialog; }
    protected getRowDefinition() { return BookshelfsRow; }
    protected getService() { return BookshelfsService.baseUrl; }
}
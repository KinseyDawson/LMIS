import { BooksColumns, BooksRow, BooksService } from '@/ServerTypes/BookManage';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { BooksDialog } from './BooksDialog';

@Decorators.registerClass('LMIS.BookManage.BooksGrid')
export class BooksGrid extends EntityGrid<BooksRow> {
    protected getColumnsKey() { return BooksColumns.columnsKey; }
    protected getDialogType() { return BooksDialog; }
    protected getRowDefinition() { return BooksRow; }
    protected getService() { return BooksService.baseUrl; }
}
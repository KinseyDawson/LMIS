import { BookColumns, BookRow, BookService } from '@/ServerTypes/BookManage';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { BookDialog } from './BookDialog';

@Decorators.registerClass('LMIS.BookManage.BookGrid')
export class BookGrid extends EntityGrid<BookRow> {
    protected getColumnsKey() { return BookColumns.columnsKey; }
    protected getDialogType() { return BookDialog; }
    protected getRowDefinition() { return BookRow; }
    protected getService() { return BookService.baseUrl; }
}
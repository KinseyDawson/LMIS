import { BookshelfColumns, BookshelfRow, BookshelfService } from '@/ServerTypes/BookManage';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { BookshelfDialog } from './BookshelfDialog';

@Decorators.registerClass('LMIS.BookManage.BookshelfGrid')
export class BookshelfGrid extends EntityGrid<BookshelfRow> {
    protected getColumnsKey() { return BookshelfColumns.columnsKey; }
    protected getDialogType() { return BookshelfDialog; }
    protected getRowDefinition() { return BookshelfRow; }
    protected getService() { return BookshelfService.baseUrl; }
}
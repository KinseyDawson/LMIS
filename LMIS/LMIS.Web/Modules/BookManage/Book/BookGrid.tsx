import { BookColumns, BookRow, BookService } from '@/ServerTypes/BookManage';
import { Decorators, htmlEncode ,confirmDialog} from '@serenity-is/corelib';
import { SelectableEntityGrid } from '@serenity-is/extensions';
import { BookDialog } from './BookDialog';
import { BookStatusEnum } from '@/ServerTypes/Modules';

@Decorators.registerClass('LMIS.BookManage.BookGrid')
export class BookGrid extends SelectableEntityGrid<BookRow,any> {
    protected getColumnsKey() { return BookColumns.columnsKey; }
    protected getDialogType() { return BookDialog; }
    protected getRowDefinition() { return BookRow; }
    protected getService() { return BookService.baseUrl; }
}
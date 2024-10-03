import { BookStoreColumns, BookStoreRow, BookStoreService } from '@/ServerTypes/InventoryManage';
import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { BookStoreDialog } from './BookStoreDialog';

@Decorators.registerClass('LMIS.InventoryManage.BookStoreGrid')
export class BookStoreGrid extends EntityGrid<BookStoreRow> {
    protected getColumnsKey() { return BookStoreColumns.columnsKey; }
    protected getDialogType() { return BookStoreDialog; }
    protected getRowDefinition() { return BookStoreRow; }
    protected getService() { return BookStoreService.baseUrl; }
    protected getButtons(): ToolButton[] {
        return [];
    }
}
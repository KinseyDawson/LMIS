import { DownBookshelfsColumns, DownBookshelfsRow, DownBookshelfsService } from '@/ServerTypes/InventoryManage';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { DownBookshelfsDialog } from './DownBookshelfsDialog';

@Decorators.registerClass('LMIS.InventoryManage.DownBookshelfsGrid')
export class DownBookshelfsGrid extends EntityGrid<DownBookshelfsRow> {
    protected getColumnsKey() { return DownBookshelfsColumns.columnsKey; }
    protected getDialogType() { return DownBookshelfsDialog; }
    protected getRowDefinition() { return DownBookshelfsRow; }
    protected getService() { return DownBookshelfsService.baseUrl; }
}
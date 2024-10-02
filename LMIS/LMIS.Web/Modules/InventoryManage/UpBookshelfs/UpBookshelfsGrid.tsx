import { UpBookshelfsColumns, UpBookshelfsRow, UpBookshelfsService } from '@/ServerTypes/InventoryManage';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { UpBookshelfsDialog } from './UpBookshelfsDialog';

@Decorators.registerClass('LMIS.InventoryManage.UpBookshelfsGrid')
export class UpBookshelfsGrid extends EntityGrid<UpBookshelfsRow> {
    protected getColumnsKey() { return UpBookshelfsColumns.columnsKey; }
    protected getDialogType() { return UpBookshelfsDialog; }
    protected getRowDefinition() { return UpBookshelfsRow; }
    protected getService() { return UpBookshelfsService.baseUrl; }
}
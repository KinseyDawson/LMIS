import { DownBookshelfColumns, DownBookshelfRow, DownBookshelfService } from '@/ServerTypes/InventoryManage';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { DownBookshelfDialog } from './DownBookshelfDialog';

@Decorators.registerClass('LMIS.InventoryManage.DownBookshelfGrid')
export class DownBookshelfGrid extends EntityGrid<DownBookshelfRow> {
    protected getColumnsKey() { return DownBookshelfColumns.columnsKey; }
    protected getDialogType() { return DownBookshelfDialog; }
    protected getRowDefinition() { return DownBookshelfRow; }
    protected getService() { return DownBookshelfService.baseUrl; }
}
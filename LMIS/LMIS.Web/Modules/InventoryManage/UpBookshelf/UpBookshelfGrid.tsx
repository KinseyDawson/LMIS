import { UpBookshelfColumns, UpBookshelfRow, UpBookshelfService } from '@/ServerTypes/InventoryManage';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { UpBookshelfDialog } from './UpBookshelfDialog';

@Decorators.registerClass('LMIS.InventoryManage.UpBookshelfGrid')
export class UpBookshelfGrid extends EntityGrid<UpBookshelfRow> {
    protected getColumnsKey() { return UpBookshelfColumns.columnsKey; }
    protected getDialogType() { return UpBookshelfDialog; }
    protected getRowDefinition() { return UpBookshelfRow; }
    protected getService() { return UpBookshelfService.baseUrl; }
}
import { BorrowColumns, BorrowRow, BorrowService } from '@/ServerTypes/ReaderManage';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { BorrowDialog } from './BorrowDialog';

@Decorators.registerClass('LMIS.ReaderManage.BorrowGrid')
export class BorrowGrid extends EntityGrid<BorrowRow> {
    protected getColumnsKey() { return BorrowColumns.columnsKey; }
    protected getDialogType() { return BorrowDialog; }
    protected getRowDefinition() { return BorrowRow; }
    protected getService() { return BorrowService.baseUrl; }
}
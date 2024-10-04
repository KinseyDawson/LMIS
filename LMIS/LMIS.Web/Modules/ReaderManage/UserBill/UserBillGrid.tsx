import { UserBillColumns, UserBillRow, UserBillService } from '@/ServerTypes/ReaderManage';
import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { UserBillDialog } from './UserBillDialog';

@Decorators.registerClass('LMIS.ReaderManage.UserBillGrid')
export class UserBillGrid extends EntityGrid<UserBillRow> {
    protected getColumnsKey() { return UserBillColumns.columnsKey; }
    protected getDialogType() { return UserBillDialog; }
    protected getRowDefinition() { return UserBillRow; }
    protected getService() { return UserBillService.baseUrl; }
    protected getButtons(): ToolButton[] {
        return [];
    }
}
import { PublishersColumns, PublishersRow, PublishersService } from '@/ServerTypes/BookManage';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PublishersDialog } from './PublishersDialog';

@Decorators.registerClass('LMIS.BookManage.PublishersGrid')
export class PublishersGrid extends EntityGrid<PublishersRow> {
    protected getColumnsKey() { return PublishersColumns.columnsKey; }
    protected getDialogType() { return PublishersDialog; }
    protected getRowDefinition() { return PublishersRow; }
    protected getService() { return PublishersService.baseUrl; }
}
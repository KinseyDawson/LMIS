import { PublisherColumns, PublisherRow, PublisherService } from '@/ServerTypes/BookManage';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PublisherDialog } from './PublisherDialog';

@Decorators.registerClass('LMIS.BookManage.PublisherGrid')
export class PublisherGrid extends EntityGrid<PublisherRow> {
    protected getColumnsKey() { return PublisherColumns.columnsKey; }
    protected getDialogType() { return PublisherDialog; }
    protected getRowDefinition() { return PublisherRow; }
    protected getService() { return PublisherService.baseUrl; }
}
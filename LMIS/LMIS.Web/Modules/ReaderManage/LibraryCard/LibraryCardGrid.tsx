import { LibraryCardColumns, LibraryCardRow, LibraryCardService } from '@/ServerTypes/ReaderManage';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { LibraryCardDialog } from './LibraryCardDialog';

@Decorators.registerClass('LMIS.ReaderManage.LibraryCardGrid')
export class LibraryCardGrid extends EntityGrid<LibraryCardRow> {
    protected getColumnsKey() { return LibraryCardColumns.columnsKey; }
    protected getDialogType() { return LibraryCardDialog; }
    protected getRowDefinition() { return LibraryCardRow; }
    protected getService() { return LibraryCardService.baseUrl; }
}
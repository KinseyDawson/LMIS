import { LibraryCardLoseColumns, LibraryCardLoseRow, LibraryCardLoseService } from '@/ServerTypes/ReaderManage';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { LibraryCardLoseDialog } from './LibraryCardLoseDialog';

@Decorators.registerClass('LMIS.ReaderManage.LibraryCardLoseGrid')
export class LibraryCardLoseGrid extends EntityGrid<LibraryCardLoseRow> {
    protected getColumnsKey() { return LibraryCardLoseColumns.columnsKey; }
    protected getDialogType() { return LibraryCardLoseDialog; }
    protected getRowDefinition() { return LibraryCardLoseRow; }
    protected getService() { return LibraryCardLoseService.baseUrl; }
}
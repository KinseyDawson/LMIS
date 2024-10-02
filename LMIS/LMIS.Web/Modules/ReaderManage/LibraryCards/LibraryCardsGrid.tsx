import { LibraryCardsColumns, LibraryCardsRow, LibraryCardsService } from '@/ServerTypes/ReaderManage';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { LibraryCardsDialog } from './LibraryCardsDialog';

@Decorators.registerClass('LMIS.ReaderManage.LibraryCardsGrid')
export class LibraryCardsGrid extends EntityGrid<LibraryCardsRow> {
    protected getColumnsKey() { return LibraryCardsColumns.columnsKey; }
    protected getDialogType() { return LibraryCardsDialog; }
    protected getRowDefinition() { return LibraryCardsRow; }
    protected getService() { return LibraryCardsService.baseUrl; }
}
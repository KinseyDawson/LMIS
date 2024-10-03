import { CardLevelColumns, CardLevelRow, CardLevelService } from '@/ServerTypes/ReaderManage';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CardLevelDialog } from './CardLevelDialog';

@Decorators.registerClass('LMIS.ReaderManage.CardLevelGrid')
export class CardLevelGrid extends EntityGrid<CardLevelRow> {
    protected getColumnsKey() { return CardLevelColumns.columnsKey; }
    protected getDialogType() { return CardLevelDialog; }
    protected getRowDefinition() { return CardLevelRow; }
    protected getService() { return CardLevelService.baseUrl; }
}
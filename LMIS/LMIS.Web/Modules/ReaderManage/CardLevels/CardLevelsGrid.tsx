import { CardLevelsColumns, CardLevelsRow, CardLevelsService } from '@/ServerTypes/ReaderManage';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CardLevelsDialog } from './CardLevelsDialog';

@Decorators.registerClass('LMIS.ReaderManage.CardLevelsGrid')
export class CardLevelsGrid extends EntityGrid<CardLevelsRow> {
    protected getColumnsKey() { return CardLevelsColumns.columnsKey; }
    protected getDialogType() { return CardLevelsDialog; }
    protected getRowDefinition() { return CardLevelsRow; }
    protected getService() { return CardLevelsService.baseUrl; }
}
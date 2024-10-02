import { CategoriesColumns, CategoriesRow, CategoriesService } from '@/ServerTypes/BookManage';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CategoriesDialog } from './CategoriesDialog';

@Decorators.registerClass('LMIS.BookManage.CategoriesGrid')
export class CategoriesGrid extends EntityGrid<CategoriesRow> {
    protected getColumnsKey() { return CategoriesColumns.columnsKey; }
    protected getDialogType() { return CategoriesDialog; }
    protected getRowDefinition() { return CategoriesRow; }
    protected getService() { return CategoriesService.baseUrl; }
}
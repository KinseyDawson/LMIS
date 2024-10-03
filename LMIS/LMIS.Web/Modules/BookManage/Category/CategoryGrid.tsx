import { CategoryColumns, CategoryRow, CategoryService } from '@/ServerTypes/BookManage';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CategoryDialog } from './CategoryDialog';

@Decorators.registerClass('LMIS.BookManage.CategoryGrid')
export class CategoryGrid extends EntityGrid<CategoryRow> {
    protected getColumnsKey() { return CategoryColumns.columnsKey; }
    protected getDialogType() { return CategoryDialog; }
    protected getRowDefinition() { return CategoryRow; }
    protected getService() { return CategoryService.baseUrl; }
}
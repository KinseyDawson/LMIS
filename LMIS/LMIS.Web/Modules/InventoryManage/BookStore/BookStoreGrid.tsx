import { BookStoreColumns, BookStoreRow, BookStoreService } from '@/ServerTypes/InventoryManage';
import { Decorators, Aggregators, ToolButton } from '@serenity-is/corelib';
import { SelectableEntityGrid } from '@serenity-is/extensions';
import { BookStoreDialog } from './BookStoreDialog';

@Decorators.registerClass('LMIS.InventoryManage.BookStoreGrid')
export class BookStoreGrid extends SelectableEntityGrid<BookStoreRow,any> {
    protected getColumnsKey() { return BookStoreColumns.columnsKey; }
    protected getDialogType() { return BookStoreDialog; }
    protected getRowDefinition() { return BookStoreRow; }
    protected getService() { return BookStoreService.baseUrl; }
    protected getButtons(): ToolButton[] {
        return [{
            title: '书架分组',
            separator: true,
            cssClass: 'expand-all-button',
            onClick: () => this.view.setGrouping(
                [{
                    getter: BookStoreRow.Fields.BookshelfLocation,
                    formatter: x =>'书架:'+x.value+' 数量:'+x.count,
                    aggregators: [
                        new Aggregators.Sum(BookStoreRow.Fields.Inventory),
                        
                    ]
                }])
        }, 
        {
            title: '删除分组',
            separator: true,
            cssClass: 'collapse-all-button',
            onClick: () => this.view.setGrouping([])
        }];
    }
}
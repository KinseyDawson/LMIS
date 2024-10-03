import { BookColumns, BookRow, BookService } from '@/ServerTypes/BookManage';
import { Decorators, htmlEncode ,confirmDialog} from '@serenity-is/corelib';
import { SelectableEntityGrid } from '@serenity-is/extensions';
import { BookDialog } from './BookDialog';
import { BookStatusEnum } from '@/ServerTypes/Modules';

@Decorators.registerClass('LMIS.BookManage.BookGrid')
export class BookGrid extends SelectableEntityGrid<BookRow,any> {
    protected getColumnsKey() { return BookColumns.columnsKey; }
    protected getDialogType() { return BookDialog; }
    protected getRowDefinition() { return BookRow; }
    protected getService() { return BookService.baseUrl; }
    protected getColumns(){
        var columns = super.getColumns();
        columns.push({
            format: ctx => {
                var buts = '';
                if (ctx.item.BookStatus == BookStatusEnum.Unborrowable) {
                    buts += htmlEncode(' ') + `<a class="inline-action" data-action="enable-row">启用</i></a>`
                }
                if (ctx.item.BookStatus== BookStatusEnum.Borrowable) {
                    buts += htmlEncode(' ') + `<a class="inline-action" data-action="disable-row">禁用</i></a>`
                }
                return buts;
            },
            name: '',
            width: 80,
            minWidth: 80,
            maxWidth: 80
        });
        return columns;
    }
    protected onClick(e: Event, row: number, cell: number): void {
        super.onClick(e, row, cell);
        var item = this.itemAt(row);
        var action = (e.target as HTMLElement).closest(".inline-action")?.getAttribute("data-action");
        if (action) {
            switch (action) {
                case "enable-row":
                    item.BookStatus = BookStatusEnum.Borrowable;
                    confirmDialog("您确定启用该书籍？", () => {
                        BookService.Update({
                            Entity: item,
                            EntityId: item.BookId,
                        }, _ => {
                            this.refresh();
                        });
                    });
                    break;
                case "disable-row":
                    confirmDialog("您确定禁用该书籍？", () => {
                        item.BookStatus = BookStatusEnum.Unborrowable;
                        BookService.Update({
                            Entity: item,
                            EntityId: item.BookId,
                        }, _ => {
                            this.refresh();
                        });
                    });
                    break;
            }
        }
    }
}
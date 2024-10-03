import { BookStoreForm, BookStoreRow, BookStoreService } from '@/ServerTypes/InventoryManage';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.InventoryManage.BookStoreDialog')
export class BookStoreDialog extends EntityDialog<BookStoreRow, any> {
    protected getFormKey() { return BookStoreForm.formKey; }
    protected getRowDefinition() { return BookStoreRow; }
    protected getService() { return BookStoreService.baseUrl; }

    protected form = new BookStoreForm(this.idPrefix);
}
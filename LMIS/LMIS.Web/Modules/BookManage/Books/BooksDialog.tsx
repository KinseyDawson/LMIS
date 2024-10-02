import { BooksForm, BooksRow, BooksService } from '@/ServerTypes/BookManage';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.BookManage.BooksDialog')
export class BooksDialog extends EntityDialog<BooksRow, any> {
    protected getFormKey() { return BooksForm.formKey; }
    protected getRowDefinition() { return BooksRow; }
    protected getService() { return BooksService.baseUrl; }

    protected form = new BooksForm(this.idPrefix);
}
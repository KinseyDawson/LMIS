import { BookshelfsForm, BookshelfsRow, BookshelfsService } from '@/ServerTypes/BookManage';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.BookManage.BookshelfsDialog')
export class BookshelfsDialog extends EntityDialog<BookshelfsRow, any> {
    protected getFormKey() { return BookshelfsForm.formKey; }
    protected getRowDefinition() { return BookshelfsRow; }
    protected getService() { return BookshelfsService.baseUrl; }

    protected form = new BookshelfsForm(this.idPrefix);
}
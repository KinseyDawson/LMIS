import { BookshelfForm, BookshelfRow, BookshelfService } from '@/ServerTypes/BookManage';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.BookManage.BookshelfDialog')
export class BookshelfDialog extends EntityDialog<BookshelfRow, any> {
    protected getFormKey() { return BookshelfForm.formKey; }
    protected getRowDefinition() { return BookshelfRow; }
    protected getService() { return BookshelfService.baseUrl; }

    protected form = new BookshelfForm(this.idPrefix);
}
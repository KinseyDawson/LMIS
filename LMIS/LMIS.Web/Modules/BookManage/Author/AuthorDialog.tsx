import { AuthorForm, AuthorRow, AuthorService } from '@/ServerTypes/BookManage';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.BookManage.AuthorDialog')
export class AuthorDialog extends EntityDialog<AuthorRow, any> {
    protected getFormKey() { return AuthorForm.formKey; }
    protected getRowDefinition() { return AuthorRow; }
    protected getService() { return AuthorService.baseUrl; }

    protected form = new AuthorForm(this.idPrefix);
}
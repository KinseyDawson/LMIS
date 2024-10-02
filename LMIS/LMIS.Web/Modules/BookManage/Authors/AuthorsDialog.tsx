import { AuthorsForm, AuthorsRow, AuthorsService } from '@/ServerTypes/BookManage';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.BookManage.AuthorsDialog')
export class AuthorsDialog extends EntityDialog<AuthorsRow, any> {
    protected getFormKey() { return AuthorsForm.formKey; }
    protected getRowDefinition() { return AuthorsRow; }
    protected getService() { return AuthorsService.baseUrl; }

    protected form = new AuthorsForm(this.idPrefix);
}
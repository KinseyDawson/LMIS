import { PublishersForm, PublishersRow, PublishersService } from '@/ServerTypes/BookManage';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.BookManage.PublishersDialog')
export class PublishersDialog extends EntityDialog<PublishersRow, any> {
    protected getFormKey() { return PublishersForm.formKey; }
    protected getRowDefinition() { return PublishersRow; }
    protected getService() { return PublishersService.baseUrl; }

    protected form = new PublishersForm(this.idPrefix);
}
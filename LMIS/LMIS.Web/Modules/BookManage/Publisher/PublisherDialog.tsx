import { PublisherForm, PublisherRow, PublisherService } from '@/ServerTypes/BookManage';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.BookManage.PublisherDialog')
export class PublisherDialog extends EntityDialog<PublisherRow, any> {
    protected getFormKey() { return PublisherForm.formKey; }
    protected getRowDefinition() { return PublisherRow; }
    protected getService() { return PublisherService.baseUrl; }

    protected form = new PublisherForm(this.idPrefix);
}
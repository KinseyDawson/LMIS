import { UpBookshelfsForm, UpBookshelfsRow, UpBookshelfsService } from '@/ServerTypes/InventoryManage';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.InventoryManage.UpBookshelfsDialog')
export class UpBookshelfsDialog extends EntityDialog<UpBookshelfsRow, any> {
    protected getFormKey() { return UpBookshelfsForm.formKey; }
    protected getRowDefinition() { return UpBookshelfsRow; }
    protected getService() { return UpBookshelfsService.baseUrl; }

    protected form = new UpBookshelfsForm(this.idPrefix);
}
import { DownBookshelfsForm, DownBookshelfsRow, DownBookshelfsService } from '@/ServerTypes/InventoryManage';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.InventoryManage.DownBookshelfsDialog')
export class DownBookshelfsDialog extends EntityDialog<DownBookshelfsRow, any> {
    protected getFormKey() { return DownBookshelfsForm.formKey; }
    protected getRowDefinition() { return DownBookshelfsRow; }
    protected getService() { return DownBookshelfsService.baseUrl; }

    protected form = new DownBookshelfsForm(this.idPrefix);
}
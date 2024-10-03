import { DownBookshelfForm, DownBookshelfRow, DownBookshelfService } from '@/ServerTypes/InventoryManage';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.InventoryManage.DownBookshelfDialog')
export class DownBookshelfDialog extends EntityDialog<DownBookshelfRow, any> {
    protected getFormKey() { return DownBookshelfForm.formKey; }
    protected getRowDefinition() { return DownBookshelfRow; }
    protected getService() { return DownBookshelfService.baseUrl; }

    protected form = new DownBookshelfForm(this.idPrefix);
}
import { UpBookshelfForm, UpBookshelfRow, UpBookshelfService } from '@/ServerTypes/InventoryManage';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.InventoryManage.UpBookshelfDialog')
export class UpBookshelfDialog extends EntityDialog<UpBookshelfRow, any> {
    protected getFormKey() { return UpBookshelfForm.formKey; }
    protected getRowDefinition() { return UpBookshelfRow; }
    protected getService() { return UpBookshelfService.baseUrl; }

    protected form = new UpBookshelfForm(this.idPrefix);
}
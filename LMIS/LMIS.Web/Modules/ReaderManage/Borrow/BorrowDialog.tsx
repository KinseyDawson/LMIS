import { BorrowForm, BorrowRow, BorrowService } from '@/ServerTypes/ReaderManage';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.ReaderManage.BorrowDialog')
export class BorrowDialog extends EntityDialog<BorrowRow, any> {
    protected getFormKey() { return BorrowForm.formKey; }
    protected getRowDefinition() { return BorrowRow; }
    protected getService() { return BorrowService.baseUrl; }

    protected form = new BorrowForm(this.idPrefix);
}
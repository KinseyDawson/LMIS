import { UserBillForm, UserBillRow, UserBillService } from '@/ServerTypes/ReaderManage';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.ReaderManage.UserBillDialog')
export class UserBillDialog extends EntityDialog<UserBillRow, any> {
    protected getFormKey() { return UserBillForm.formKey; }
    protected getRowDefinition() { return UserBillRow; }
    protected getService() { return UserBillService.baseUrl; }

    protected form = new UserBillForm(this.idPrefix);
}
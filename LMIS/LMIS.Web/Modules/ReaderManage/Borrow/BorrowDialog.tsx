import { BorrowForm, BorrowRow, BorrowService } from '@/ServerTypes/ReaderManage';
import { Decorators, EntityDialog,ToolButton } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.ReaderManage.BorrowDialog')
export class BorrowDialog extends EntityDialog<BorrowRow, any> {
    protected getFormKey() { return BorrowForm.formKey; }
    protected getRowDefinition() { return BorrowRow; }
    protected getService() { return BorrowService.baseUrl; }

    protected form = new BorrowForm(this.idPrefix);
    protected getToolbarButtons(): ToolButton[] {
        var buttons=super.getToolbarButtons();
        return buttons.filter(x => x.action == "save-and-close"||x.action=="apply-changes");
    }
}
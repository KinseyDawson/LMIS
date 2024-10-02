import { LibraryCardLoseForm, LibraryCardLoseRow, LibraryCardLoseService } from '@/ServerTypes/ReaderManage';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.ReaderManage.LibraryCardLoseDialog')
export class LibraryCardLoseDialog extends EntityDialog<LibraryCardLoseRow, any> {
    protected getFormKey() { return LibraryCardLoseForm.formKey; }
    protected getRowDefinition() { return LibraryCardLoseRow; }
    protected getService() { return LibraryCardLoseService.baseUrl; }

    protected form = new LibraryCardLoseForm(this.idPrefix);
}
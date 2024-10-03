import { LibraryCardForm, LibraryCardRow, LibraryCardService } from '@/ServerTypes/ReaderManage';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.ReaderManage.LibraryCardDialog')
export class LibraryCardDialog extends EntityDialog<LibraryCardRow, any> {
    protected getFormKey() { return LibraryCardForm.formKey; }
    protected getRowDefinition() { return LibraryCardRow; }
    protected getService() { return LibraryCardService.baseUrl; }

    protected form = new LibraryCardForm(this.idPrefix);
}
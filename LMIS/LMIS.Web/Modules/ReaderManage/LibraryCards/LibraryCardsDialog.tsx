import { LibraryCardsForm, LibraryCardsRow, LibraryCardsService } from '@/ServerTypes/ReaderManage';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.ReaderManage.LibraryCardsDialog')
export class LibraryCardsDialog extends EntityDialog<LibraryCardsRow, any> {
    protected getFormKey() { return LibraryCardsForm.formKey; }
    protected getRowDefinition() { return LibraryCardsRow; }
    protected getService() { return LibraryCardsService.baseUrl; }

    protected form = new LibraryCardsForm(this.idPrefix);
}
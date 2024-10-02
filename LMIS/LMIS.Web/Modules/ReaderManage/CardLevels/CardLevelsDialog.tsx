import { CardLevelsForm, CardLevelsRow, CardLevelsService } from '@/ServerTypes/ReaderManage';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.ReaderManage.CardLevelsDialog')
export class CardLevelsDialog extends EntityDialog<CardLevelsRow, any> {
    protected getFormKey() { return CardLevelsForm.formKey; }
    protected getRowDefinition() { return CardLevelsRow; }
    protected getService() { return CardLevelsService.baseUrl; }

    protected form = new CardLevelsForm(this.idPrefix);
}
import { CardLevelForm, CardLevelRow, CardLevelService } from '@/ServerTypes/ReaderManage';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.ReaderManage.CardLevelDialog')
export class CardLevelDialog extends EntityDialog<CardLevelRow, any> {
    protected getFormKey() { return CardLevelForm.formKey; }
    protected getRowDefinition() { return CardLevelRow; }
    protected getService() { return CardLevelService.baseUrl; }

    protected form = new CardLevelForm(this.idPrefix);
}
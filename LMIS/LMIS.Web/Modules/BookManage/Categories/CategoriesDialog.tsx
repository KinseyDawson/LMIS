import { CategoriesForm, CategoriesRow, CategoriesService } from '@/ServerTypes/BookManage';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('LMIS.BookManage.CategoriesDialog')
export class CategoriesDialog extends EntityDialog<CategoriesRow, any> {
    protected getFormKey() { return CategoriesForm.formKey; }
    protected getRowDefinition() { return CategoriesRow; }
    protected getService() { return CategoriesService.baseUrl; }

    protected form = new CategoriesForm(this.idPrefix);
}
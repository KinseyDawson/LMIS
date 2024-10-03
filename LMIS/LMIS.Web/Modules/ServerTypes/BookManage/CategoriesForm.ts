import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface CategoriesForm {
    CategoryName: StringEditor;
}

export class CategoriesForm extends PrefixedContext {
    static readonly formKey = 'BookManage.Categories';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategoriesForm.init)  {
            CategoriesForm.init = true;

            var w0 = StringEditor;

            initFormType(CategoriesForm, [
                'CategoryName', w0
            ]);
        }
    }
}
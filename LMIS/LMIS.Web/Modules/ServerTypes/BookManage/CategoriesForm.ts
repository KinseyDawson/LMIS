import { StringEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface CategoriesForm {
    CategoryName: StringEditor;
    CreateTime: DateEditor;
    UpdateTime: DateEditor;
}

export class CategoriesForm extends PrefixedContext {
    static readonly formKey = 'BookManage.Categories';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategoriesForm.init)  {
            CategoriesForm.init = true;

            var w0 = StringEditor;
            var w1 = DateEditor;

            initFormType(CategoriesForm, [
                'CategoryName', w0,
                'CreateTime', w1,
                'UpdateTime', w1
            ]);
        }
    }
}
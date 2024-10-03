import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface CategoryForm {
    CategoryName: StringEditor;
}

export class CategoryForm extends PrefixedContext {
    static readonly formKey = 'BookManage.Category';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategoryForm.init)  {
            CategoryForm.init = true;

            var w0 = StringEditor;

            initFormType(CategoryForm, [
                'CategoryName', w0
            ]);
        }
    }
}
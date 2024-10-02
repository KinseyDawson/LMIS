import { StringEditor, IntegerEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AuthorsForm {
    AuthorName: StringEditor;
    Sex: IntegerEditor;
    Email: StringEditor;
    AuthorImage: StringEditor;
    CreateTime: DateEditor;
    UpdateTime: DateEditor;
}

export class AuthorsForm extends PrefixedContext {
    static readonly formKey = 'BookManage.Authors';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AuthorsForm.init)  {
            AuthorsForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = DateEditor;

            initFormType(AuthorsForm, [
                'AuthorName', w0,
                'Sex', w1,
                'Email', w0,
                'AuthorImage', w0,
                'CreateTime', w2,
                'UpdateTime', w2
            ]);
        }
    }
}
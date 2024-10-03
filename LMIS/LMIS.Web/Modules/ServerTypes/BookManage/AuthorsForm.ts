import { StringEditor, EnumEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { SexEnum } from "../Modules/Common.Enums.SexEnum";

export interface AuthorsForm {
    AuthorName: StringEditor;
    Sex: EnumEditor;
    Email: StringEditor;
    AuthorImage: StringEditor;
}

export class AuthorsForm extends PrefixedContext {
    static readonly formKey = 'BookManage.Authors';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AuthorsForm.init)  {
            AuthorsForm.init = true;

            var w0 = StringEditor;
            var w1 = EnumEditor;

            initFormType(AuthorsForm, [
                'AuthorName', w0,
                'Sex', w1,
                'Email', w0,
                'AuthorImage', w0
            ]);
        }
    }
}

[SexEnum]; // referenced types
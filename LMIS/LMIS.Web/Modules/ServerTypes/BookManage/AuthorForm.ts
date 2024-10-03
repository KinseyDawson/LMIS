import { StringEditor, EnumEditor, EmailAddressEditor, ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { SexEnum } from "../Modules/Common.Enums.SexEnum";

export interface AuthorForm {
    AuthorName: StringEditor;
    Sex: EnumEditor;
    Email: EmailAddressEditor;
    AuthorImage: ImageUploadEditor;
}

export class AuthorForm extends PrefixedContext {
    static readonly formKey = 'BookManage.Author';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AuthorForm.init)  {
            AuthorForm.init = true;

            var w0 = StringEditor;
            var w1 = EnumEditor;
            var w2 = EmailAddressEditor;
            var w3 = ImageUploadEditor;

            initFormType(AuthorForm, [
                'AuthorName', w0,
                'Sex', w1,
                'Email', w2,
                'AuthorImage', w3
            ]);
        }
    }
}

[SexEnum]; // referenced types
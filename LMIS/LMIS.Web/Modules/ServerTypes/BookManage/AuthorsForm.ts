import { StringEditor, EnumEditor, EmailAddressEditor, ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { SexEnum } from "../Modules/Common.Enums.SexEnum";

export interface AuthorsForm {
    AuthorName: StringEditor;
    Sex: EnumEditor;
    Email: EmailAddressEditor;
    AuthorImage: ImageUploadEditor;
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
            var w2 = EmailAddressEditor;
            var w3 = ImageUploadEditor;

            initFormType(AuthorsForm, [
                'AuthorName', w0,
                'Sex', w1,
                'Email', w2,
                'AuthorImage', w3
            ]);
        }
    }
}

[SexEnum]; // referenced types
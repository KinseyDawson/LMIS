import { StringEditor, EmailAddressEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PublisherForm {
    PublisherName: StringEditor;
    Contact: StringEditor;
    ContactPhone: StringEditor;
    Email: EmailAddressEditor;
}

export class PublisherForm extends PrefixedContext {
    static readonly formKey = 'BookManage.Publisher';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PublisherForm.init)  {
            PublisherForm.init = true;

            var w0 = StringEditor;
            var w1 = EmailAddressEditor;

            initFormType(PublisherForm, [
                'PublisherName', w0,
                'Contact', w0,
                'ContactPhone', w0,
                'Email', w1
            ]);
        }
    }
}
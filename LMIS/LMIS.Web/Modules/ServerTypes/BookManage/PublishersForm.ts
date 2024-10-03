import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PublishersForm {
    PublisherName: StringEditor;
    Contact: StringEditor;
    ContactPhone: StringEditor;
    Email: StringEditor;
}

export class PublishersForm extends PrefixedContext {
    static readonly formKey = 'BookManage.Publishers';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PublishersForm.init)  {
            PublishersForm.init = true;

            var w0 = StringEditor;

            initFormType(PublishersForm, [
                'PublisherName', w0,
                'Contact', w0,
                'ContactPhone', w0,
                'Email', w0
            ]);
        }
    }
}
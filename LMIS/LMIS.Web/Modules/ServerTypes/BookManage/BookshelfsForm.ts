import { StringEditor, ServiceLookupEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface BookshelfsForm {
    Location: StringEditor;
    CategoryId: ServiceLookupEditor;
    BookshelfImage: StringEditor;
    BookCount: StringEditor;
    BookCapacity: StringEditor;
    CreateTime: DateEditor;
    UpdateTime: DateEditor;
}

export class BookshelfsForm extends PrefixedContext {
    static readonly formKey = 'BookManage.Bookshelfs';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!BookshelfsForm.init)  {
            BookshelfsForm.init = true;

            var w0 = StringEditor;
            var w1 = ServiceLookupEditor;
            var w2 = DateEditor;

            initFormType(BookshelfsForm, [
                'Location', w0,
                'CategoryId', w1,
                'BookshelfImage', w0,
                'BookCount', w0,
                'BookCapacity', w0,
                'CreateTime', w2,
                'UpdateTime', w2
            ]);
        }
    }
}
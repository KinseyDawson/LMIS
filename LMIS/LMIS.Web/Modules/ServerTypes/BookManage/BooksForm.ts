import { StringEditor, ServiceLookupEditor, DateEditor, IntegerEditor, DecimalEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface BooksForm {
    BookName: StringEditor;
    Cn: StringEditor;
    Issn: StringEditor;
    Isbn: StringEditor;
    AuthorId: ServiceLookupEditor;
    PublisherId: ServiceLookupEditor;
    PublisheDate: DateEditor;
    Page: IntegerEditor;
    Price: DecimalEditor;
    Inventory: StringEditor;
    BookStatus: IntegerEditor;
    BookImage: StringEditor;
    CreateTime: DateEditor;
    UpdateTime: DateEditor;
}

export class BooksForm extends PrefixedContext {
    static readonly formKey = 'BookManage.Books';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!BooksForm.init)  {
            BooksForm.init = true;

            var w0 = StringEditor;
            var w1 = ServiceLookupEditor;
            var w2 = DateEditor;
            var w3 = IntegerEditor;
            var w4 = DecimalEditor;

            initFormType(BooksForm, [
                'BookName', w0,
                'Cn', w0,
                'Issn', w0,
                'Isbn', w0,
                'AuthorId', w1,
                'PublisherId', w1,
                'PublisheDate', w2,
                'Page', w3,
                'Price', w4,
                'Inventory', w0,
                'BookStatus', w3,
                'BookImage', w0,
                'CreateTime', w2,
                'UpdateTime', w2
            ]);
        }
    }
}
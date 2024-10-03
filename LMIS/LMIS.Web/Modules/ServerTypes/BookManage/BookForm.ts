import { StringEditor, ServiceLookupEditor, DateEditor, IntegerEditor, DecimalEditor, EnumEditor, ImageUploadEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { BookStatusEnum } from "../Modules/BookManage.Book.BookStatusEnum";

export interface BookForm {
    BookName: StringEditor;
    CN: StringEditor;
    ISSN: StringEditor;
    ISBN: StringEditor;
    AuthorId: ServiceLookupEditor;
    PublisherId: ServiceLookupEditor;
    PublisheDate: DateEditor;
    Page: IntegerEditor;
    Price: DecimalEditor;
    BookStatus: EnumEditor;
    BookImage: ImageUploadEditor;
}

export class BookForm extends PrefixedContext {
    static readonly formKey = 'BookManage.Book';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!BookForm.init)  {
            BookForm.init = true;

            var w0 = StringEditor;
            var w1 = ServiceLookupEditor;
            var w2 = DateEditor;
            var w3 = IntegerEditor;
            var w4 = DecimalEditor;
            var w5 = EnumEditor;
            var w6 = ImageUploadEditor;

            initFormType(BookForm, [
                'BookName', w0,
                'CN', w0,
                'ISSN', w0,
                'ISBN', w0,
                'AuthorId', w1,
                'PublisherId', w1,
                'PublisheDate', w2,
                'Page', w3,
                'Price', w4,
                'BookStatus', w5,
                'BookImage', w6
            ]);
        }
    }
}

[BookStatusEnum]; // referenced types
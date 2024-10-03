import { StringEditor, ServiceLookupEditor, ImageUploadEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface BookshelfForm {
    Location: StringEditor;
    CategoryId: ServiceLookupEditor;
    BookshelfImage: ImageUploadEditor;
    BookCount: IntegerEditor;
    BookCapacity: IntegerEditor;
}

export class BookshelfForm extends PrefixedContext {
    static readonly formKey = 'BookManage.Bookshelf';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!BookshelfForm.init)  {
            BookshelfForm.init = true;

            var w0 = StringEditor;
            var w1 = ServiceLookupEditor;
            var w2 = ImageUploadEditor;
            var w3 = IntegerEditor;

            initFormType(BookshelfForm, [
                'Location', w0,
                'CategoryId', w1,
                'BookshelfImage', w2,
                'BookCount', w3,
                'BookCapacity', w3
            ]);
        }
    }
}
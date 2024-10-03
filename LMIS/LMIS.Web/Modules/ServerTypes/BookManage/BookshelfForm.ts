import { StringEditor, ServiceLookupEditor, ImageUploadEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface BookshelfForm {
    Location: StringEditor;
    CategoryId: ServiceLookupEditor;
    BookshelfImage: ImageUploadEditor;
    BookCount: StringEditor;
    BookCapacity: StringEditor;
    CreateTime: DateEditor;
    UpdateTime: DateEditor;
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
            var w3 = DateEditor;

            initFormType(BookshelfForm, [
                'Location', w0,
                'CategoryId', w1,
                'BookshelfImage', w2,
                'BookCount', w0,
                'BookCapacity', w0,
                'CreateTime', w3,
                'UpdateTime', w3
            ]);
        }
    }
}
import { ServiceLookupEditor, StringEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface BookStoreForm {
    BookId: ServiceLookupEditor;
    BookshelfId: ServiceLookupEditor;
    Inventory: StringEditor;
    CreateTime: DateEditor;
    UpdateTime: DateEditor;
}

export class BookStoreForm extends PrefixedContext {
    static readonly formKey = 'InventoryManage.BookStore';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!BookStoreForm.init)  {
            BookStoreForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = StringEditor;
            var w2 = DateEditor;

            initFormType(BookStoreForm, [
                'BookId', w0,
                'BookshelfId', w0,
                'Inventory', w1,
                'CreateTime', w2,
                'UpdateTime', w2
            ]);
        }
    }
}
import { ServiceLookupEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface UpBookshelfForm {
    BookId: ServiceLookupEditor;
    BookshelfId: ServiceLookupEditor;
    Inventory: IntegerEditor;
}

export class UpBookshelfForm extends PrefixedContext {
    static readonly formKey = 'InventoryManage.UpBookshelf';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!UpBookshelfForm.init)  {
            UpBookshelfForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = IntegerEditor;

            initFormType(UpBookshelfForm, [
                'BookId', w0,
                'BookshelfId', w0,
                'Inventory', w1
            ]);
        }
    }
}
import { ServiceLookupEditor, IntegerEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface UpBookshelfForm {
    BookId: ServiceLookupEditor;
    BookshelfId: ServiceLookupEditor;
    Inventory: IntegerEditor;
    Remark: StringEditor;
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
            var w2 = StringEditor;

            initFormType(UpBookshelfForm, [
                'BookId', w0,
                'BookshelfId', w0,
                'Inventory', w1,
                'Remark', w2
            ]);
        }
    }
}
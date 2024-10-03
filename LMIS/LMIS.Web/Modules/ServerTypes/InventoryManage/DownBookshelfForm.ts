import { ServiceLookupEditor, IntegerEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface DownBookshelfForm {
    BookId: ServiceLookupEditor;
    BookshelfId: ServiceLookupEditor;
    Inventory: IntegerEditor;
    Remark: StringEditor;
}

export class DownBookshelfForm extends PrefixedContext {
    static readonly formKey = 'InventoryManage.DownBookshelf';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DownBookshelfForm.init)  {
            DownBookshelfForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = IntegerEditor;
            var w2 = StringEditor;

            initFormType(DownBookshelfForm, [
                'BookId', w0,
                'BookshelfId', w0,
                'Inventory', w1,
                'Remark', w2
            ]);
        }
    }
}
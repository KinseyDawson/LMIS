import { ServiceLookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface DownBookshelfForm {
    BookId: ServiceLookupEditor;
    BookshelfId: ServiceLookupEditor;
}

export class DownBookshelfForm extends PrefixedContext {
    static readonly formKey = 'InventoryManage.DownBookshelf';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DownBookshelfForm.init)  {
            DownBookshelfForm.init = true;

            var w0 = ServiceLookupEditor;

            initFormType(DownBookshelfForm, [
                'BookId', w0,
                'BookshelfId', w0
            ]);
        }
    }
}
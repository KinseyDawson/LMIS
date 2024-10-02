import { ServiceLookupEditor, StringEditor, LookupEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface UpBookshelfsForm {
    BookId: ServiceLookupEditor;
    BookshelfId: ServiceLookupEditor;
    Inventory: StringEditor;
    OperateUserId: LookupEditor;
    CreateTime: DateEditor;
    UpdateTime: DateEditor;
}

export class UpBookshelfsForm extends PrefixedContext {
    static readonly formKey = 'InventoryManage.UpBookshelfs';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!UpBookshelfsForm.init)  {
            UpBookshelfsForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = StringEditor;
            var w2 = LookupEditor;
            var w3 = DateEditor;

            initFormType(UpBookshelfsForm, [
                'BookId', w0,
                'BookshelfId', w0,
                'Inventory', w1,
                'OperateUserId', w2,
                'CreateTime', w3,
                'UpdateTime', w3
            ]);
        }
    }
}
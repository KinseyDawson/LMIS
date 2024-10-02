import { ServiceLookupEditor, LookupEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface DownBookshelfsForm {
    BookId: ServiceLookupEditor;
    BookshelfId: ServiceLookupEditor;
    OperateUserId: LookupEditor;
    CreateTime: DateEditor;
    UpdateTime: DateEditor;
}

export class DownBookshelfsForm extends PrefixedContext {
    static readonly formKey = 'InventoryManage.DownBookshelfs';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DownBookshelfsForm.init)  {
            DownBookshelfsForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = LookupEditor;
            var w2 = DateEditor;

            initFormType(DownBookshelfsForm, [
                'BookId', w0,
                'BookshelfId', w0,
                'OperateUserId', w1,
                'CreateTime', w2,
                'UpdateTime', w2
            ]);
        }
    }
}
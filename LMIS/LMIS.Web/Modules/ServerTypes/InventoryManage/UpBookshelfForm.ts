import { StringEditor, LookupEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface UpBookshelfForm {
    BookId: StringEditor;
    BookshelfId: StringEditor;
    Inventory: StringEditor;
    OperateUserId: LookupEditor;
    CreateTime: DateEditor;
    UpdateTime: DateEditor;
}

export class UpBookshelfForm extends PrefixedContext {
    static readonly formKey = 'InventoryManage.UpBookshelf';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!UpBookshelfForm.init)  {
            UpBookshelfForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;
            var w2 = DateEditor;

            initFormType(UpBookshelfForm, [
                'BookId', w0,
                'BookshelfId', w0,
                'Inventory', w0,
                'OperateUserId', w1,
                'CreateTime', w2,
                'UpdateTime', w2
            ]);
        }
    }
}
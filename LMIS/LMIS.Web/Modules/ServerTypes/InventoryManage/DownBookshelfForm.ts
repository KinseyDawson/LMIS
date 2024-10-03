import { StringEditor, LookupEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface DownBookshelfForm {
    BookId: StringEditor;
    BookshelfId: StringEditor;
    OperateUserId: LookupEditor;
    CreateTime: DateEditor;
    UpdateTime: DateEditor;
}

export class DownBookshelfForm extends PrefixedContext {
    static readonly formKey = 'InventoryManage.DownBookshelf';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DownBookshelfForm.init)  {
            DownBookshelfForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;
            var w2 = DateEditor;

            initFormType(DownBookshelfForm, [
                'BookId', w0,
                'BookshelfId', w0,
                'OperateUserId', w1,
                'CreateTime', w2,
                'UpdateTime', w2
            ]);
        }
    }
}
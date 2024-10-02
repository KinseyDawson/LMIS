import { ServiceLookupEditor, LookupEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface LibraryCardLoseForm {
    LibraryCardId: ServiceLookupEditor;
    OperateUserId: LookupEditor;
    CreateTime: DateEditor;
    UpdateTime: DateEditor;
}

export class LibraryCardLoseForm extends PrefixedContext {
    static readonly formKey = 'ReaderManage.LibraryCardLose';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!LibraryCardLoseForm.init)  {
            LibraryCardLoseForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = LookupEditor;
            var w2 = DateEditor;

            initFormType(LibraryCardLoseForm, [
                'LibraryCardId', w0,
                'OperateUserId', w1,
                'CreateTime', w2,
                'UpdateTime', w2
            ]);
        }
    }
}
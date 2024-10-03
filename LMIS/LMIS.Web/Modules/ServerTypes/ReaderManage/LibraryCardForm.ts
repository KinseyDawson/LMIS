import { StringEditor, LookupEditor, ServiceLookupEditor, IntegerEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface LibraryCardForm {
    LibraryCardNo: StringEditor;
    UserId: LookupEditor;
    LevelId: ServiceLookupEditor;
    Status: IntegerEditor;
    CreateTime: DateEditor;
    UpdateTime: DateEditor;
}

export class LibraryCardForm extends PrefixedContext {
    static readonly formKey = 'ReaderManage.LibraryCard';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!LibraryCardForm.init)  {
            LibraryCardForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;
            var w2 = ServiceLookupEditor;
            var w3 = IntegerEditor;
            var w4 = DateEditor;

            initFormType(LibraryCardForm, [
                'LibraryCardNo', w0,
                'UserId', w1,
                'LevelId', w2,
                'Status', w3,
                'CreateTime', w4,
                'UpdateTime', w4
            ]);
        }
    }
}
import { LookupEditor, ServiceLookupEditor, EnumEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { LibraryCardStatusEnum } from "../Modules/ReaderManage.LibraryCard.LibraryCardStatusEnum";

export interface LibraryCardForm {
    UserId: LookupEditor;
    LevelId: ServiceLookupEditor;
    Status: EnumEditor;
}

export class LibraryCardForm extends PrefixedContext {
    static readonly formKey = 'ReaderManage.LibraryCard';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!LibraryCardForm.init)  {
            LibraryCardForm.init = true;

            var w0 = LookupEditor;
            var w1 = ServiceLookupEditor;
            var w2 = EnumEditor;

            initFormType(LibraryCardForm, [
                'UserId', w0,
                'LevelId', w1,
                'Status', w2
            ]);
        }
    }
}

[LibraryCardStatusEnum]; // referenced types
import { LookupEditor, ServiceLookupEditor, EnumEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { BorrowStatusEnum } from "../Modules/ReaderManage.Borrow.BorrowStatusEnum";

export interface BorrowForm {
    UserId: LookupEditor;
    BookId: ServiceLookupEditor;
    BorrowStatus: EnumEditor;
}

export class BorrowForm extends PrefixedContext {
    static readonly formKey = 'ReaderManage.Borrow';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!BorrowForm.init)  {
            BorrowForm.init = true;

            var w0 = LookupEditor;
            var w1 = ServiceLookupEditor;
            var w2 = EnumEditor;

            initFormType(BorrowForm, [
                'UserId', w0,
                'BookId', w1,
                'BorrowStatus', w2
            ]);
        }
    }
}

[BorrowStatusEnum]; // referenced types
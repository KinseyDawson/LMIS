import { LookupEditor, EnumEditor, DecimalEditor, StringEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";
import { BillTypeEnum } from "../Modules/ReaderManage.UserBill.BillTypeEnum";

export interface UserBillForm {
    UserId: LookupEditor;
    Type: EnumEditor;
    Fee: DecimalEditor;
    Remark: StringEditor;
    CreateTime: DateEditor;
    UpdateTime: DateEditor;
}

export class UserBillForm extends PrefixedContext {
    static readonly formKey = 'ReaderManage.UserBill';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!UserBillForm.init)  {
            UserBillForm.init = true;

            var w0 = LookupEditor;
            var w1 = EnumEditor;
            var w2 = DecimalEditor;
            var w3 = StringEditor;
            var w4 = DateEditor;

            initFormType(UserBillForm, [
                'UserId', w0,
                'Type', w1,
                'Fee', w2,
                'Remark', w3,
                'CreateTime', w4,
                'UpdateTime', w4
            ]);
        }
    }
}

[BillTypeEnum]; // referenced types
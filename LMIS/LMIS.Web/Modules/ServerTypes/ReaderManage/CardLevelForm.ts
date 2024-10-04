import { StringEditor, DecimalEditor, IntegerEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface CardLevelForm {
    CardLevelName: StringEditor;
    Fee: DecimalEditor;
    Discount: DecimalEditor;
    Penalty: DecimalEditor;
    BorrowDays: IntegerEditor;
    BorrowBooks: IntegerEditor;
}

export class CardLevelForm extends PrefixedContext {
    static readonly formKey = 'ReaderManage.CardLevel';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CardLevelForm.init)  {
            CardLevelForm.init = true;

            var w0 = StringEditor;
            var w1 = DecimalEditor;
            var w2 = IntegerEditor;

            initFormType(CardLevelForm, [
                'CardLevelName', w0,
                'Fee', w1,
                'Discount', w1,
                'Penalty', w1,
                'BorrowDays', w2,
                'BorrowBooks', w2
            ]);
        }
    }
}
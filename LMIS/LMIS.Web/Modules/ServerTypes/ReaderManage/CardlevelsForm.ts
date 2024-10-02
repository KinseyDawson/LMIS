import { StringEditor, DecimalEditor, IntegerEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface CardLevelsForm {
    CardLevelName: StringEditor;
    Discount: DecimalEditor;
    Penalty: DecimalEditor;
    BorrowDays: IntegerEditor;
    BorrowBooks: IntegerEditor;
    CreateTime: DateEditor;
    UpdateTime: DateEditor;
}

export class CardLevelsForm extends PrefixedContext {
    static readonly formKey = 'ReaderManage.CardLevels';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CardLevelsForm.init)  {
            CardLevelsForm.init = true;

            var w0 = StringEditor;
            var w1 = DecimalEditor;
            var w2 = IntegerEditor;
            var w3 = DateEditor;

            initFormType(CardLevelsForm, [
                'CardLevelName', w0,
                'Discount', w1,
                'Penalty', w1,
                'BorrowDays', w2,
                'BorrowBooks', w2,
                'CreateTime', w3,
                'UpdateTime', w3
            ]);
        }
    }
}
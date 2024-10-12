import { UserBillColumns, UserBillRow, UserBillService } from '@/ServerTypes/ReaderManage';
import { Decorators, EntityGrid, ToolButton, Aggregators } from '@serenity-is/corelib';
import { UserBillDialog } from './UserBillDialog';

@Decorators.registerClass('LMIS.ReaderManage.UserBillGrid')
export class UserBillGrid extends EntityGrid<UserBillRow> {
    protected getColumnsKey() { return UserBillColumns.columnsKey; }
    protected getDialogType() { return UserBillDialog; }
    protected getRowDefinition() { return UserBillRow; }
    protected getService() { return UserBillService.baseUrl; }
    protected getButtons(): ToolButton[] {
        return [{
            title: '费用类型分组',
            separator: true,
            cssClass: 'expand-all-button',
            onClick: () => this.view.setGrouping(
                [{
                    getter: UserBillRow.Fields.Type,
                    formatter: x => '费用类型:' + this.getTypeDes(x.value) + ' 数量:' + x.count,
                    aggregators: [
                        new Aggregators.Sum(UserBillRow.Fields.Fee)
                    ]
                }])
        },
        {
            title: '删除分组',
            separator: true,
            cssClass: 'collapse-all-button',
            onClick: () => this.view.setGrouping([])
        }];
    }
    private getTypeDes(typeVal) {
        switch (typeVal) {
            case 1:
                return "办卡"
            case 2:
                return "借阅卡升级"
            case 3:
                return "借阅租金"
            case 4:
                return "过期处罚"
            case 5:
                return "书籍赔偿"
            default:
                return "办卡"
        }
    }
}
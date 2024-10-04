import { fieldsProxy } from "@serenity-is/corelib";

export interface UserBillRow {
    UserBillId?: number;
    UserId?: number;
    Type?: number;
    Fee?: number;
    Remark?: string;
    CreateTime?: string;
    UpdateTime?: string;
    UserName?: string;
}

export abstract class UserBillRow {
    static readonly idProperty = 'UserBillId';
    static readonly nameProperty = 'Remark';
    static readonly localTextPrefix = 'ReaderManage.UserBill';
    static readonly deletePermission = 'ReaderManage:UserBill';
    static readonly insertPermission = 'ReaderManage:UserBill';
    static readonly readPermission = 'ReaderManage:UserBill';
    static readonly updatePermission = 'ReaderManage:UserBill';

    static readonly Fields = fieldsProxy<UserBillRow>();
}
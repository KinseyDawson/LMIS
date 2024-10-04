import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { UserBillRow } from "./UserBillRow";

export namespace UserBillService {
    export const baseUrl = 'ReaderManage/UserBill';

    export declare function Create(request: SaveRequest<UserBillRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<UserBillRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<UserBillRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<UserBillRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<UserBillRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<UserBillRow>>;

    export const Methods = {
        Create: "ReaderManage/UserBill/Create",
        Update: "ReaderManage/UserBill/Update",
        Delete: "ReaderManage/UserBill/Delete",
        Retrieve: "ReaderManage/UserBill/Retrieve",
        List: "ReaderManage/UserBill/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>UserBillService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
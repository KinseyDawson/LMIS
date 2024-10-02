import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { UpBookshelfsRow } from "./UpBookshelfsRow";

export namespace UpBookshelfsService {
    export const baseUrl = 'InventoryManage/UpBookshelfs';

    export declare function Create(request: SaveRequest<UpBookshelfsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<UpBookshelfsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<UpBookshelfsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<UpBookshelfsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<UpBookshelfsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<UpBookshelfsRow>>;

    export const Methods = {
        Create: "InventoryManage/UpBookshelfs/Create",
        Update: "InventoryManage/UpBookshelfs/Update",
        Delete: "InventoryManage/UpBookshelfs/Delete",
        Retrieve: "InventoryManage/UpBookshelfs/Retrieve",
        List: "InventoryManage/UpBookshelfs/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>UpBookshelfsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { DownBookshelfsRow } from "./DownBookshelfsRow";

export namespace DownBookshelfsService {
    export const baseUrl = 'InventoryManage/DownBookshelfs';

    export declare function Create(request: SaveRequest<DownBookshelfsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<DownBookshelfsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<DownBookshelfsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<DownBookshelfsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<DownBookshelfsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<DownBookshelfsRow>>;

    export const Methods = {
        Create: "InventoryManage/DownBookshelfs/Create",
        Update: "InventoryManage/DownBookshelfs/Update",
        Delete: "InventoryManage/DownBookshelfs/Delete",
        Retrieve: "InventoryManage/DownBookshelfs/Retrieve",
        List: "InventoryManage/DownBookshelfs/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>DownBookshelfsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
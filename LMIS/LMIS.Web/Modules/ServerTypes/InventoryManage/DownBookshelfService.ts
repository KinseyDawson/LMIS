import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { DownBookshelfRow } from "./DownBookshelfRow";

export namespace DownBookshelfService {
    export const baseUrl = 'InventoryManage/DownBookshelf';

    export declare function Create(request: SaveRequest<DownBookshelfRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<DownBookshelfRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<DownBookshelfRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<DownBookshelfRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<DownBookshelfRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<DownBookshelfRow>>;

    export const Methods = {
        Create: "InventoryManage/DownBookshelf/Create",
        Update: "InventoryManage/DownBookshelf/Update",
        Delete: "InventoryManage/DownBookshelf/Delete",
        Retrieve: "InventoryManage/DownBookshelf/Retrieve",
        List: "InventoryManage/DownBookshelf/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>DownBookshelfService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
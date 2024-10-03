import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { UpBookshelfRow } from "./UpBookshelfRow";

export namespace UpBookshelfService {
    export const baseUrl = 'InventoryManage/UpBookshelf';

    export declare function Create(request: SaveRequest<UpBookshelfRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<UpBookshelfRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<UpBookshelfRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<UpBookshelfRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<UpBookshelfRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<UpBookshelfRow>>;

    export const Methods = {
        Create: "InventoryManage/UpBookshelf/Create",
        Update: "InventoryManage/UpBookshelf/Update",
        Delete: "InventoryManage/UpBookshelf/Delete",
        Retrieve: "InventoryManage/UpBookshelf/Retrieve",
        List: "InventoryManage/UpBookshelf/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>UpBookshelfService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
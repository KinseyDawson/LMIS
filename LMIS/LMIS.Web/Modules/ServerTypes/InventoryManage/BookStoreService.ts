import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { BookStoreRow } from "./BookStoreRow";

export namespace BookStoreService {
    export const baseUrl = 'InventoryManage/BookStore';

    export declare function Create(request: SaveRequest<BookStoreRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<BookStoreRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<BookStoreRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<BookStoreRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<BookStoreRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<BookStoreRow>>;

    export const Methods = {
        Create: "InventoryManage/BookStore/Create",
        Update: "InventoryManage/BookStore/Update",
        Delete: "InventoryManage/BookStore/Delete",
        Retrieve: "InventoryManage/BookStore/Retrieve",
        List: "InventoryManage/BookStore/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>BookStoreService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
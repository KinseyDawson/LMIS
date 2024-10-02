import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { BooksRow } from "./BooksRow";

export namespace BooksService {
    export const baseUrl = 'BookManage/Books';

    export declare function Create(request: SaveRequest<BooksRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<BooksRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<BooksRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<BooksRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<BooksRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<BooksRow>>;

    export const Methods = {
        Create: "BookManage/Books/Create",
        Update: "BookManage/Books/Update",
        Delete: "BookManage/Books/Delete",
        Retrieve: "BookManage/Books/Retrieve",
        List: "BookManage/Books/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>BooksService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
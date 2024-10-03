import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { BookRow } from "./BookRow";

export namespace BookService {
    export const baseUrl = 'BookManage/Book';

    export declare function Create(request: SaveRequest<BookRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<BookRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<BookRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<BookRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<BookRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<BookRow>>;

    export const Methods = {
        Create: "BookManage/Book/Create",
        Update: "BookManage/Book/Update",
        Delete: "BookManage/Book/Delete",
        Retrieve: "BookManage/Book/Retrieve",
        List: "BookManage/Book/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>BookService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
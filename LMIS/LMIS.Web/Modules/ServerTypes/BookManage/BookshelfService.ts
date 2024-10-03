import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { BookshelfRow } from "./BookshelfRow";

export namespace BookshelfService {
    export const baseUrl = 'BookManage/Bookshelf';

    export declare function Create(request: SaveRequest<BookshelfRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<BookshelfRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<BookshelfRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<BookshelfRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<BookshelfRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<BookshelfRow>>;

    export const Methods = {
        Create: "BookManage/Bookshelf/Create",
        Update: "BookManage/Bookshelf/Update",
        Delete: "BookManage/Bookshelf/Delete",
        Retrieve: "BookManage/Bookshelf/Retrieve",
        List: "BookManage/Bookshelf/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>BookshelfService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { BookshelfsRow } from "./BookshelfsRow";

export namespace BookshelfsService {
    export const baseUrl = 'BookManage/Bookshelfs';

    export declare function Create(request: SaveRequest<BookshelfsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<BookshelfsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<BookshelfsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<BookshelfsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<BookshelfsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<BookshelfsRow>>;

    export const Methods = {
        Create: "BookManage/Bookshelfs/Create",
        Update: "BookManage/Bookshelfs/Update",
        Delete: "BookManage/Bookshelfs/Delete",
        Retrieve: "BookManage/Bookshelfs/Retrieve",
        List: "BookManage/Bookshelfs/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>BookshelfsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { AuthorRow } from "./AuthorRow";

export namespace AuthorService {
    export const baseUrl = 'BookManage/Author';

    export declare function Create(request: SaveRequest<AuthorRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<AuthorRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<AuthorRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<AuthorRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<AuthorRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<AuthorRow>>;

    export const Methods = {
        Create: "BookManage/Author/Create",
        Update: "BookManage/Author/Update",
        Delete: "BookManage/Author/Delete",
        Retrieve: "BookManage/Author/Retrieve",
        List: "BookManage/Author/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>AuthorService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { AuthorsRow } from "./AuthorsRow";

export namespace AuthorsService {
    export const baseUrl = 'BookManage/Authors';

    export declare function Create(request: SaveRequest<AuthorsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<AuthorsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<AuthorsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<AuthorsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<AuthorsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<AuthorsRow>>;

    export const Methods = {
        Create: "BookManage/Authors/Create",
        Update: "BookManage/Authors/Update",
        Delete: "BookManage/Authors/Delete",
        Retrieve: "BookManage/Authors/Retrieve",
        List: "BookManage/Authors/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>AuthorsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
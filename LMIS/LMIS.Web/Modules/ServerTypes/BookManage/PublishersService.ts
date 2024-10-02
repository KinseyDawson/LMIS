import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { PublishersRow } from "./PublishersRow";

export namespace PublishersService {
    export const baseUrl = 'BookManage/Publishers';

    export declare function Create(request: SaveRequest<PublishersRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<PublishersRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<PublishersRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<PublishersRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<PublishersRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<PublishersRow>>;

    export const Methods = {
        Create: "BookManage/Publishers/Create",
        Update: "BookManage/Publishers/Update",
        Delete: "BookManage/Publishers/Delete",
        Retrieve: "BookManage/Publishers/Retrieve",
        List: "BookManage/Publishers/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>PublishersService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
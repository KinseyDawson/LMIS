import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { PublisherRow } from "./PublisherRow";

export namespace PublisherService {
    export const baseUrl = 'BookManage/Publisher';

    export declare function Create(request: SaveRequest<PublisherRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<PublisherRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<PublisherRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<PublisherRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<PublisherRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<PublisherRow>>;

    export const Methods = {
        Create: "BookManage/Publisher/Create",
        Update: "BookManage/Publisher/Update",
        Delete: "BookManage/Publisher/Delete",
        Retrieve: "BookManage/Publisher/Retrieve",
        List: "BookManage/Publisher/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>PublisherService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
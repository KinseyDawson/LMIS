import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { LibraryCardLoseRow } from "./LibraryCardLoseRow";

export namespace LibraryCardLoseService {
    export const baseUrl = 'ReaderManage/LibraryCardLose';

    export declare function Create(request: SaveRequest<LibraryCardLoseRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<LibraryCardLoseRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<LibraryCardLoseRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<LibraryCardLoseRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<LibraryCardLoseRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<LibraryCardLoseRow>>;

    export const Methods = {
        Create: "ReaderManage/LibraryCardLose/Create",
        Update: "ReaderManage/LibraryCardLose/Update",
        Delete: "ReaderManage/LibraryCardLose/Delete",
        Retrieve: "ReaderManage/LibraryCardLose/Retrieve",
        List: "ReaderManage/LibraryCardLose/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>LibraryCardLoseService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
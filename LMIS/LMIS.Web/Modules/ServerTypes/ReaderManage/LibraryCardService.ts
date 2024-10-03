import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { LibraryCardRow } from "./LibraryCardRow";

export namespace LibraryCardService {
    export const baseUrl = 'ReaderManage/LibraryCard';

    export declare function Create(request: SaveRequest<LibraryCardRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<LibraryCardRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<LibraryCardRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<LibraryCardRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<LibraryCardRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<LibraryCardRow>>;

    export const Methods = {
        Create: "ReaderManage/LibraryCard/Create",
        Update: "ReaderManage/LibraryCard/Update",
        Delete: "ReaderManage/LibraryCard/Delete",
        Retrieve: "ReaderManage/LibraryCard/Retrieve",
        List: "ReaderManage/LibraryCard/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>LibraryCardService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
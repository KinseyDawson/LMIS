import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { LibraryCardsRow } from "./LibraryCardsRow";

export namespace LibraryCardsService {
    export const baseUrl = 'ReaderManage/LibraryCards';

    export declare function Create(request: SaveRequest<LibraryCardsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<LibraryCardsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<LibraryCardsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<LibraryCardsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<LibraryCardsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<LibraryCardsRow>>;

    export const Methods = {
        Create: "ReaderManage/LibraryCards/Create",
        Update: "ReaderManage/LibraryCards/Update",
        Delete: "ReaderManage/LibraryCards/Delete",
        Retrieve: "ReaderManage/LibraryCards/Retrieve",
        List: "ReaderManage/LibraryCards/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>LibraryCardsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
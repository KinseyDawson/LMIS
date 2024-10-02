import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { CardLevelsRow } from "./CardLevelsRow";

export namespace CardLevelsService {
    export const baseUrl = 'ReaderManage/CardLevels';

    export declare function Create(request: SaveRequest<CardLevelsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<CardLevelsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CardLevelsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<CardLevelsRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CardLevelsRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<CardLevelsRow>>;

    export const Methods = {
        Create: "ReaderManage/CardLevels/Create",
        Update: "ReaderManage/CardLevels/Update",
        Delete: "ReaderManage/CardLevels/Delete",
        Retrieve: "ReaderManage/CardLevels/Retrieve",
        List: "ReaderManage/CardLevels/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CardLevelsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
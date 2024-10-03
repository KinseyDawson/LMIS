import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { CardLevelRow } from "./CardLevelRow";

export namespace CardLevelService {
    export const baseUrl = 'ReaderManage/CardLevel';

    export declare function Create(request: SaveRequest<CardLevelRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<CardLevelRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CardLevelRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<CardLevelRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CardLevelRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<CardLevelRow>>;

    export const Methods = {
        Create: "ReaderManage/CardLevel/Create",
        Update: "ReaderManage/CardLevel/Update",
        Delete: "ReaderManage/CardLevel/Delete",
        Retrieve: "ReaderManage/CardLevel/Retrieve",
        List: "ReaderManage/CardLevel/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CardLevelService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
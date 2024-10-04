import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { BorrowRow } from "./BorrowRow";

export namespace BorrowService {
    export const baseUrl = 'ReaderManage/Borrow';

    export declare function Create(request: SaveRequest<BorrowRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<BorrowRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<BorrowRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<BorrowRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<BorrowRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<BorrowRow>>;

    export const Methods = {
        Create: "ReaderManage/Borrow/Create",
        Update: "ReaderManage/Borrow/Update",
        Delete: "ReaderManage/Borrow/Delete",
        Retrieve: "ReaderManage/Borrow/Retrieve",
        List: "ReaderManage/Borrow/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>BorrowService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
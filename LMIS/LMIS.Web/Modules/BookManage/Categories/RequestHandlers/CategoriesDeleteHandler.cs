﻿using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = LMIS.BookManage.CategoriesRow;

namespace LMIS.BookManage;

public interface ICategoriesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class CategoriesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICategoriesDeleteHandler
{
    public CategoriesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
﻿
namespace LMIS;

public interface IDirectoryService
{
    AppServices.DirectoryEntry Validate(string username, string password);
}
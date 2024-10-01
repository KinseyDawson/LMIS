namespace LMIS.Administration;

public class UserRoleUpdateRequest : ServiceRequest
{
    public long? UserID { get; set; }
    public List<long> Roles { get; set; }
}
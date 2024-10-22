using MyRow = LMIS.Administration.RoleRow;

namespace LMIS.Administration;
public static class RoleHelper
{
    private static MyRow.RowFields Fld { get { return MyRow.Fields; } }
    public static Dictionary<long, MyRow> GetRoleById(ITwoLevelCache cache, ISqlConnections sqlConnections)
    {
        if (cache is null)
            throw new ArgumentNullException(nameof(cache));

        return cache.GetLocalStoreOnly("RoleById", TimeSpan.Zero,
            Fld.GenerationKey, () =>
            {
                if (sqlConnections is null)
                    throw new ArgumentNullException(nameof(sqlConnections));

                using var connection = sqlConnections.NewFor<MyRow>();
                return connection.List<MyRow>().ToDictionary(x => x.RoleId.Value);
            });
    }

    public static IEnumerable<MyRow> GetRoles(IDbConnection dbConnection, int userId)
    {
        var sqlText = @"SELECT
	                        b.*
                        FROM
	                        userroles a
                        LEFT JOIN roles b ON
	                        (a.RoleId = b.RoleId)
                        WHERE
	                        a.UserId = @UserId";
        return dbConnection.Query<MyRow>(sqlText, new { UserId = userId });
    }
}

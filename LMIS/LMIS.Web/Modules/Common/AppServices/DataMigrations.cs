using FluentMigrator.Runner;
using FluentMigrator.Runner.Conventions;
using FluentMigrator.Runner.Initialization;
using FluentMigrator.Runner.Processors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.IO;

namespace LMIS.AppServices;
public class DataMigrations(ITypeSource typeSource,
    ISqlConnections sqlConnections,
    IWebHostEnvironment hostEnvironment) : IDataMigrations
{
    private static readonly string[] databaseKeys = [
        "Default"
    ];

    private readonly ITypeSource typeSource = typeSource ?? throw new ArgumentNullException(nameof(typeSource));
    private readonly ISqlConnections sqlConnections = sqlConnections ?? throw new ArgumentNullException(nameof(sqlConnections));
    private readonly IWebHostEnvironment hostEnvironment = hostEnvironment ?? throw new ArgumentNullException(nameof(hostEnvironment));

    public void Initialize()
    {
        foreach (var databaseKey in databaseKeys)
        {
            EnsureDatabase(databaseKey);
            RunMigrations(databaseKey);
        }
    }
    private void EnsureDatabase(string databaseKey)
    {
        MigrationUtils.EnsureDatabase(databaseKey,
            hostEnvironment.ContentRootPath, sqlConnections);
        Microsoft.Data.SqlClient.SqlConnection.ClearAllPools();
    }

    private void RunMigrations(string databaseKey)
    {
        var cs = sqlConnections.TryGetConnectionString(databaseKey) ??
            throw new ArgumentOutOfRangeException(nameof(databaseKey));
        var conventionSet = new DefaultConventionSet(defaultSchemaName: null,
            Path.GetDirectoryName(typeof(DataMigrations).Assembly.Location));
        var serviceProvider = new ServiceCollection()
            .AddLogging(lb => lb.AddFluentMigratorConsole())
            .AddFluentMigratorCore()
            .AddSingleton<IConventionSet>(conventionSet)
            .Configure<ProcessorOptions>(options =>
            {
                options.Timeout = TimeSpan.FromSeconds(90);
            })
            .Configure<RunnerOptions>(options =>
            {
                options.Tags = [databaseKey + "DB"];
                options.IncludeUntaggedMigrations = databaseKey == "Default";
            })
            .ConfigureRunner(builder =>
            {
                builder.AddMySql5();
                builder.WithGlobalConnectionString(cs.ConnectionString);
                builder.ScanIn(((IGetAssemblies)typeSource).GetAssemblies().ToArray()).For.Migrations();
            })
            .BuildServiceProvider();

        var culture = CultureInfo.CurrentCulture;
        try
        {
            using var scope = serviceProvider.CreateScope();
            var runner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();
            runner.MigrateUp();
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException("Error executing migration!", ex);
        }
    }
}
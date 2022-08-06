using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Karpine.Fpo.Data;
using Volo.Abp.DependencyInjection;

namespace Karpine.Fpo.EntityFrameworkCore;

public class EntityFrameworkCoreFpoDbSchemaMigrator
    : IFpoDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreFpoDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the FpoDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<FpoDbContext>()
            .Database
            .MigrateAsync();
    }
}

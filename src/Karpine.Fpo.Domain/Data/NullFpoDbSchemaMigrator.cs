using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Karpine.Fpo.Data;

/* This is used if database provider does't define
 * IFpoDbSchemaMigrator implementation.
 */
public class NullFpoDbSchemaMigrator : IFpoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

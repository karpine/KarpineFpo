using System.Threading.Tasks;

namespace Karpine.Fpo.Data;

public interface IFpoDbSchemaMigrator
{
    Task MigrateAsync();
}

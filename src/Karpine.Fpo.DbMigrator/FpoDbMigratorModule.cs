using Karpine.Fpo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Karpine.Fpo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(FpoEntityFrameworkCoreModule),
    typeof(FpoApplicationContractsModule)
    )]
public class FpoDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}

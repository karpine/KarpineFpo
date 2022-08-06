using Karpine.Fpo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Karpine.Fpo;

[DependsOn(
    typeof(FpoEntityFrameworkCoreTestModule)
    )]
public class FpoDomainTestModule : AbpModule
{

}

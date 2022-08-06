using Volo.Abp.Modularity;

namespace Karpine.Fpo;

[DependsOn(
    typeof(FpoApplicationModule),
    typeof(FpoDomainTestModule)
    )]
public class FpoApplicationTestModule : AbpModule
{

}

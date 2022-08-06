using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Karpine.Fpo.Blazor;

[Dependency(ReplaceServices = true)]
public class FpoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Fpo";
}

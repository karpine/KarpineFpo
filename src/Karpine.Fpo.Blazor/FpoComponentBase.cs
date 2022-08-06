using Karpine.Fpo.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Karpine.Fpo.Blazor;

public abstract class FpoComponentBase : AbpComponentBase
{
    protected FpoComponentBase()
    {
        LocalizationResource = typeof(FpoResource);
    }
}

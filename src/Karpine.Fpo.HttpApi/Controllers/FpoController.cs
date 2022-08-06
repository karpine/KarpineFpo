using Karpine.Fpo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Karpine.Fpo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class FpoController : AbpControllerBase
{
    protected FpoController()
    {
        LocalizationResource = typeof(FpoResource);
    }
}

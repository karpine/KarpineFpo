using System;
using System.Collections.Generic;
using System.Text;
using Karpine.Fpo.Localization;
using Volo.Abp.Application.Services;

namespace Karpine.Fpo;

/* Inherit your application services from this class.
 */
public abstract class FpoAppService : ApplicationService
{
    protected FpoAppService()
    {
        LocalizationResource = typeof(FpoResource);
    }
}

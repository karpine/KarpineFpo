using Volo.Abp.Settings;

namespace Karpine.Fpo.Settings;

public class FpoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(FpoSettings.MySetting1));
    }
}

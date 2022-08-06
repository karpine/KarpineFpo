using Karpine.Fpo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Karpine.Fpo.Permissions;

public class FpoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(FpoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(FpoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<FpoResource>(name);
    }
}

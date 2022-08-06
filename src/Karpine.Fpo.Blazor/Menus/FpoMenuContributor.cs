using System.Threading.Tasks;
using Karpine.Fpo.Localization;
using Karpine.Fpo.MultiTenancy;
using Volo.Abp.Identity.Blazor;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.UI.Navigation;

namespace Karpine.Fpo.Blazor.Menus;

public class FpoMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<FpoResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                FpoMenus.Home,
                l["Menu:Home"],
                "/",
                icon: "fas fa-home",
                order: 0
            )
        );
       
       
        context.Menu.Items.Insert(
          0,
          new ApplicationMenuItem(
              "SupplyChainSummary",
              "Supply Chain Summary",
             "/CropStages/CropStageSummary",
              icon: "fas fa-warehouse",
              order: 1
          )
      );
        context.Menu.Items.Insert(
         0,
         new ApplicationMenuItem(
             "InventoryTrail",
             "Inventory Trail",
            "/Trails/TrailSummary",
             icon: "fas fa-tablet",
             order: 2
         )
     );

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);

        return Task.CompletedTask;
    }
}

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Volo.Abp.UI.Navigation;
using System.Collections;
using System.Collections.Generic;

namespace Karpine.Fpo.Blazor.Pages.Shared;

public partial class NavMenu : IDisposable
{
    [Inject]
    protected IMenuManager MenuManager { get; set; }

    [Inject]
    protected AuthenticationStateProvider AuthenticationStateProvider { get; set; }

    protected ApplicationMenu Menu { get; set; }

    List<TreeData> LocalData = new List<TreeData>();
    protected override async Task OnInitializedAsync()
    {
        Menu = await MenuManager.GetMainMenuAsync();
        foreach (var menuItem in Menu.Items)
        {
            LocalData.Add(FirstLevel(menuItem));
        }
   
        AuthenticationStateProvider.AuthenticationStateChanged += AuthenticationStateProviderOnAuthenticationStateChanged;
    }

    private string FormatUrl(string Url)
    {
       return (Url == null) ? "#" : Url.TrimStart('/', '~');
    }
    private TreeData FirstLevel(ApplicationMenuItem menuItem)
    {
        TreeData t = new TreeData() { Id = menuItem.Name, Url = FormatUrl(menuItem.Url), IcoCss = menuItem.Icon, Name = menuItem.DisplayName, HasChild = (!menuItem.IsLeaf) };
        if (!menuItem.IsLeaf)
        {
            t.Child = new List<TreeData>();
            foreach (var m in menuItem.Items)
            {
                t.Child.Add(SecondLevel(m));
            }
        }
        return t;
    }
    private TreeData SecondLevel(ApplicationMenuItem menuItem)
    {
        TreeData t = new TreeData() { Id = menuItem.Name, Url = FormatUrl(menuItem.Url), IcoCss = menuItem.Icon, Name = menuItem.DisplayName, HasChild = (!menuItem.IsLeaf) };

        if (!menuItem.IsLeaf)
        {
            t.Child = new List<TreeData>();
            foreach (var m in menuItem.Items)
            {
                t.Child.Add(SecondLevel(m));
            }
        }
        return t;
    }

    public void Dispose()
    {
        AuthenticationStateProvider.AuthenticationStateChanged -= AuthenticationStateProviderOnAuthenticationStateChanged;
    }

    private async void AuthenticationStateProviderOnAuthenticationStateChanged(Task<AuthenticationState> task)
    {
        Menu = await MenuManager.GetMainMenuAsync();
        await InvokeAsync(StateHasChanged);
    }
}

class TreeData
{
    public string Id { get; set; }
    public string Pid { get; set; }
    public string Name { get; set; }
    public bool HasChild { get; set; }
    public bool Expanded { get; set; }
    public bool Selected { get; set; }

    public string IcoCss { get; set; }
    public string Url { get; set; }

    public List<TreeData> Child { get; set; }
}

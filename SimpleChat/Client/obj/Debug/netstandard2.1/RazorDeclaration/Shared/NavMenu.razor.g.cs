// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SimpleChat.Client.Shared
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\_Imports.razor"
using SimpleChat.Client

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\_Imports.razor"
using SimpleChat.Client.Shared

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\_Imports.razor"
using BlazorPro.Spinkit

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\_Imports.razor"
using System.Net.Http.Json

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\_Imports.razor"
using System.IO

#nullable disable
    ;
#nullable restore
#line 11 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\_Imports.razor"
using BlazorInputFile

#line default
#line hidden
#nullable disable
    ;
    #nullable restore
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    private async Task Logout()
    {
        await LocalStorageService.RemoveItemAsync("userId");
        NavigationManager.NavigateTo("user/signout", true);
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 2 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Shared\NavMenu.razor"
        Blazored.LocalStorage.ILocalStorageService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 2 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Shared\NavMenu.razor"
                                                   LocalStorageService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 1 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Shared\NavMenu.razor"
        NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 1 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Shared\NavMenu.razor"
                          NavigationManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591

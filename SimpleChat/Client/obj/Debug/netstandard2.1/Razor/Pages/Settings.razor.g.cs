#pragma checksum "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Settings.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "07f846c1109cd0a23512c45fe7cbfd68bc9fd104539aebc86cf21fd0e84be5d7"
// <auto-generated/>
#pragma warning disable 1591
namespace SimpleChat.Client.Pages
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

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Settings.razor"
 using SimpleChat.Shared.ViewModels

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Settings.razor"
 using SimpleChat.Shared.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Settings.razor"
      "/settings"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Settings : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2><b>Settings</b></h2> \n<hr>\n\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 11 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Settings.razor"
                  _settingsViewModel

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\n    \n    ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-12");
                __builder2.AddMarkupContent(7, "\n        ");
                __builder2.OpenElement(8, "input");
                __builder2.AddAttribute(9, "type", "checkbox");
                __builder2.AddAttribute(10, "checked", 
#nullable restore
#line 14 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Settings.razor"
                                         _settingsViewModel.Notifications

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(11, "id", "chkNotification");
                __builder2.AddAttribute(12, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Settings.razor"
                                                                                                             e => UpdateNotifications(e)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.AddMarkupContent(14, "<label> Notification </label>\n        <br>\n\n        ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "type", "checkbox");
                __builder2.AddAttribute(17, "checked", 
#nullable restore
#line 18 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Settings.razor"
                                         _settingsViewModel.DarkTheme

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(18, "id", "chkDarkTheme");
                __builder2.AddAttribute(19, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Settings.razor"
                                                                                                      e => UpdateTheme(e)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\n        ");
                __builder2.AddMarkupContent(21, "<label> Dark Theme </label>\n        <br>\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\n\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Settings.razor"
       
    private SettingsViewModel _settingsViewModel = new SettingsViewModel();
    long UserId;

    protected override async Task OnInitializedAsync()
    {
        UserId = await LocalStorageService.GetItemAsync<long>("userId");
        User user = await HttpClient.GetFromJsonAsync<User>("user/getprofile/" + UserId);

        _settingsViewModel = user;
    }

    private async Task UpdateTheme(ChangeEventArgs changeEventArgs)
    {
        User user = await HttpClient.GetFromJsonAsync<User>($"user/updatetheme?userId={UserId}&value={changeEventArgs.Value.ToString()}");
        
        await JSRuntime.InvokeVoidAsync("setTheme", "site" + user.DarkTheme);
    }

    private async Task UpdateNotifications(ChangeEventArgs changeEventArgs)
    {
        object obj = await HttpClient.GetFromJsonAsync<object>($"user/updatenotifications?userId={UserId}&value={changeEventArgs.Value.ToString()}");
        
    }


#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 6 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Settings.razor"
        IJSRuntime

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 6 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Settings.razor"
                   JSRuntime

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 5 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Settings.razor"
        Blazored.LocalStorage.ILocalStorageService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 5 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Settings.razor"
                                                   LocalStorageService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 4 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Settings.razor"
        HttpClient

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 4 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Settings.razor"
                   HttpClient

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
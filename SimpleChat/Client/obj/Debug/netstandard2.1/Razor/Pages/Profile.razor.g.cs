#pragma checksum "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\Pages\Profile.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e038a1fb22933ee6a89257d77a39caf4613ad9e2fdc29e756a3de37f1c371507"
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
#line 1 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\_Imports.razor"
using System.Net.Http.Json

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\_Imports.razor"
using SimpleChat.Client

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\_Imports.razor"
using SimpleChat.Client.Shared

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\Pages\Profile.razor"
 using SimpleChat.ViewModels

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\Pages\Profile.razor"
 using SimpleChat.Shared.Models

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\Pages\Profile.razor"
 using System.Security.Claims

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\Pages\Profile.razor"
      "/profile"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Profile : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2><b>Profile</b></h2> \n<hr>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-8");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "class", "form-control");
            __builder.AddAttribute(7, "placeholder", "first name");
            __builder.AddAttribute(8, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\Pages\Profile.razor"
                                    _profileViewModel.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _profileViewModel.FirstName = __value, _profileViewModel.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n    <br>\n    ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "placeholder", "last name");
            __builder.AddAttribute(15, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\Pages\Profile.razor"
                                    _profileViewModel.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _profileViewModel.LastName = __value, _profileViewModel.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n    <br>\n    ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "text");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "placeholder", "email address");
            __builder.AddAttribute(22, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\Pages\Profile.razor"
                                    _profileViewModel.EmailAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _profileViewModel.EmailAddress = __value, _profileViewModel.EmailAddress));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n    <br>\n    ");
            __builder.OpenElement(25, "textarea");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "placeholder", "about me");
            __builder.AddAttribute(28, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\Pages\Profile.razor"
                                          _profileViewModel.AboutMe

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _profileViewModel.AboutMe = __value, _profileViewModel.AboutMe));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n    <br>\n    ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddAttribute(33, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\Pages\Profile.razor"
                                              _profileViewModel.UpdateProfile

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Update Profile");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n    ");
            __builder.AddMarkupContent(36, "<span>&nbsp;&nbsp;</span>");
            __builder.AddContent(37, 
#nullable restore
#line 21 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\Pages\Profile.razor"
                              _profileViewModel.Message

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(38, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\Pages\Profile.razor"
       

    [CascadingParameter]
    public Task<AuthenticationState> authenticationState { get; set; }

    protected override async Task OnInitializedAsync() 
    {
        var authState = await authenticationState;//_authenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if(user.Identity.IsAuthenticated)
        {
            var claim = user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier);
            _profileViewModel.UserId = Convert.ToInt64(claim?.Value) ;
            await _profileViewModel.GetProfile();
        }
        else
        {
            _navigationManager.NavigateTo("/");
        }
        
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 6 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\Pages\Profile.razor"
        NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 6 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\Pages\Profile.razor"
                          _navigationManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 5 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\Pages\Profile.razor"
        IProfileViewModel

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 5 "C:\Users\Admin\source\repos\BlazingChat-main\BlazingChat-main\Source Code By Episodes\SimpleChat_01\SimpleChat\Client\Pages\Profile.razor"
                          _profileViewModel

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591

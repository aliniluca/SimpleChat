#pragma checksum "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a0d8c77e1aec5a2c78ddfa56f33663f422aa494a38faed45f854c88c7327a11e"
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
#line 2 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
 using SimpleChat.Shared.ViewModels

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
 using SimpleChat.Shared.Models

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
 using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
 using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
      "/contacts"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Contacts : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "    using SimpleChat.Shared.ViewModels;\r\n    using SimpleChat.Shared.Models;\r\n\r\n");
            __builder.AddMarkupContent(1, "<h2><b>Contacts</b></h2> \r\n<hr>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "list-group table-wrapper-scroll-y my-custom-scrollbar");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<global::BlazorPro.Spinkit.SpinLoader>(5);
            __builder.AddAttribute(6, "IsLoading", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 16 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
                             _contactsViewModel.ChatViewModelList == null

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "LoadingTemplate", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "style", "height: 900px; background-color: lightgray; vertical-align: middle;");
                __builder2.AddMarkupContent(11, "\r\n                <br><br>\r\n                ");
                __builder2.OpenComponent<global::BlazorPro.Spinkit.Chase>(12);
                __builder2.AddAttribute(13, "Center", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 21 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
                               true

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(14, "Size", (object)("70px"));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        ");
            }
            ));
            __builder.AddAttribute(17, "ContentTemplate", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, "\r\n");
#nullable restore
#line 26 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
             if(_contactsViewModel.ChatViewModelList != null)
            {
                

#line default
#line hidden
#nullable disable

#nullable restore
#line 28 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
                 foreach(ChatViewModel chatViewModel in _contactsViewModel.ChatViewModelList)
                {

#line default
#line hidden
#nullable disable

                __builder2.AddContent(19, "                    ");
                __builder2.OpenElement(20, "a");
                __builder2.AddAttribute(21, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
                                   e => NavigateToChat(chatViewModel.UserId)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "class", "list-group-item list-group-item-action flex-column align-items-start");
                __builder2.AddMarkupContent(23, "\r\n                        ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "d-flex w-100 justify-content-between");
                __builder2.AddMarkupContent(26, "\r\n");
#nullable restore
#line 32 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
                             if(chatViewModel.FirstName != null || chatViewModel.LastName != null)
                            {

#line default
#line hidden
#nullable disable

                __builder2.AddContent(27, "                                ");
                __builder2.OpenElement(28, "h6");
                __builder2.AddAttribute(29, "class", "mb-1");
                __builder2.OpenElement(30, "b");
                __builder2.AddContent(31, 
#nullable restore
#line 34 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
                                                     chatViewModel.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(32, "<span> </span>");
                __builder2.AddContent(33, 
#nullable restore
#line 34 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
                                                                                           chatViewModel.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n");
#nullable restore
#line 35 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable

                __builder2.AddContent(35, "                                ");
                __builder2.OpenElement(36, "h6");
                __builder2.AddAttribute(37, "class", "mb-1");
                __builder2.OpenElement(38, "b");
                __builder2.AddContent(39, 
#nullable restore
#line 38 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
                                                     chatViewModel.EmailAddress

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n");
#nullable restore
#line 39 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
                            }

#line default
#line hidden
#nullable disable

                __builder2.AddMarkupContent(41, "                            \r\n                            ");
                __builder2.OpenElement(42, "small");
                __builder2.AddContent(43, 
#nullable restore
#line 41 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
                                    chatViewModel.TimeSinceLastMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                        ");
                __builder2.OpenElement(46, "p");
                __builder2.AddAttribute(47, "class", "mb-1");
                __builder2.AddContent(48, 
#nullable restore
#line 43 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
                                         chatViewModel.LastMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n");
#nullable restore
#line 45 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
                }

#line default
#line hidden
#nullable disable

#nullable restore
#line 45 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
                 
            }

#line default
#line hidden
#nullable disable

                __builder2.AddContent(51, "        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
       
    
    [CascadingParameter]
    public Task<AuthenticationState> authenticationStateTask { get; set; }
    private ContactsViewModel _contactsViewModel = new ContactsViewModel();
    ClaimsPrincipal loggedinUser;

    protected async override Task OnInitializedAsync()
    {
        loggedinUser = (await authenticationStateTask).User;

        await LoadContacts();
    }

    private void NavigateToChat(long userId)
    {
        string argUserId = Convert.ToString(userId);
        NavigationManager.NavigateTo("chat/" + argUserId);
    }

    private async Task LoadContacts()
    {
        await Task.Delay(200);
        //hopefully this will be something that I can do properly    
        List<User> UserList = await HttpClient.GetFromJsonAsync<List<User>>("user/getallusers");
        _contactsViewModel.ChatViewModelList = new List<ChatViewModel>();
        
        foreach(User user in UserList)
        {
            if(loggedinUser.Identity.Name != user.EmailAddress)
                _contactsViewModel.ChatViewModelList.Add(new ChatViewModel(user.UserId,user.FirstName, user.LastName, user.EmailAddress));
        }
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 10 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
        AuthenticationStateProvider

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 10 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
                                    AuthenticationStateProvider

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 9 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
        HttpClient

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 9 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
                   HttpClient

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 8 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
        NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 8 "C:\Users\Admin\Downloads\BlazingChat-main\BlazingChat-main\Source Code By Episodes\Episode_01\BlazingChat\Client\Pages\Contacts.razor"
                          NavigationManager

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591

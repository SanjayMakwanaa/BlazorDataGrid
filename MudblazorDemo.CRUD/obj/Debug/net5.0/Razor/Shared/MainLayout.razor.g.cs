#pragma checksum "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d9f0d2621e530604979051b701936b3116c04e1"
// <auto-generated/>
#pragma warning disable 1591
namespace MudblazorDemo.CRUD.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\_Imports.razor"
using MudblazorDemo.CRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\_Imports.razor"
using MudblazorDemo.CRUD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-dtor50n8ts");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-dtor50n8ts");
            __builder.OpenComponent<global::MudblazorDemo.CRUD.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-dtor50n8ts");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-dtor50n8ts><a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-dtor50n8ts>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-dtor50n8ts");
#nullable restore
#line 14 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Shared\MainLayout.razor"
__builder.AddContent(15, Body);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenComponent<global::MudBlazor.MudThemeProvider>(17);
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, " \r\n");
            __builder.OpenComponent<global::MudBlazor.MudSnackbarProvider>(19);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7d05695499c3f3254a3150e06792b2b3b36ca53"
// <auto-generated/>
#pragma warning disable 1591
namespace MudblazorDemo.CRUD.Pages
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
#nullable restore
#line 3 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
using MudblazorDemo.CRUD.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::MudBlazor.MudCard>(0);
            __builder.AddAttribute(1, "Elevation", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 9 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                    25

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudCardHeader>(3);
                __builder2.AddAttribute(4, "CardHeaderContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudText>(5);
                    __builder3.AddAttribute(6, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 12 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                           Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(7, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(8, "Add / Edit Customers");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenComponent<global::MudBlazor.MudCardContent>(10);
                __builder2.AddAttribute(11, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    global::__Blazor.MudblazorDemo.CRUD.Pages.Index.TypeInference.CreateMudTextField_0(__builder3, 12, 13, "First Name", 14, 
#nullable restore
#line 16 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                                                   Variant.Text

#line default
#line hidden
#nullable disable
                    , 15, 
#nullable restore
#line 16 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                                                                         Margin.Normal

#line default
#line hidden
#nullable disable
                    , 16, 
#nullable restore
#line 16 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                   customer.FirstName

#line default
#line hidden
#nullable disable
                    , 17, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.FirstName = __value, customer.FirstName)));
                    __builder3.AddMarkupContent(18, "\r\n        ");
                    global::__Blazor.MudblazorDemo.CRUD.Pages.Index.TypeInference.CreateMudTextField_1(__builder3, 19, 20, "Last Name", 21, 
#nullable restore
#line 17 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                                                 Variant.Text

#line default
#line hidden
#nullable disable
                    , 22, 
#nullable restore
#line 17 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                                                                       Margin.Normal

#line default
#line hidden
#nullable disable
                    , 23, 
#nullable restore
#line 17 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                   customer.LastName

#line default
#line hidden
#nullable disable
                    , 24, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.LastName = __value, customer.LastName)));
                    __builder3.AddMarkupContent(25, "\r\n        ");
                    global::__Blazor.MudblazorDemo.CRUD.Pages.Index.TypeInference.CreateMudTextField_2(__builder3, 26, 27, "Phone Number", 28, 
#nullable restore
#line 18 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                                                       Variant.Text

#line default
#line hidden
#nullable disable
                    , 29, 
#nullable restore
#line 18 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                                                                             Margin.Normal

#line default
#line hidden
#nullable disable
                    , 30, 
#nullable restore
#line 18 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                   customer.PhoneNumber

#line default
#line hidden
#nullable disable
                    , 31, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.PhoneNumber = __value, customer.PhoneNumber)));
                    __builder3.AddMarkupContent(32, "\r\n        \r\n        ");
                    __builder3.OpenComponent<global::MudBlazor.MudButton>(33);
                    __builder3.AddAttribute(34, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 20 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                            Variant.Filled

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(35, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 20 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                   Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                                           Save

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(37, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(38, "Save Customer");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n<br>\r\n");
            global::__Blazor.MudblazorDemo.CRUD.Pages.Index.TypeInference.CreateMudTable_3(__builder, 40, 41, 
#nullable restore
#line 24 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                     25

#line default
#line hidden
#nullable disable
            , 42, 
#nullable restore
#line 24 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                GetCustomers()

#line default
#line hidden
#nullable disable
            , 43, 
#nullable restore
#line 24 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                        new Func<Customer, bool>(Search)

#line default
#line hidden
#nullable disable
            , 44, 
#nullable restore
#line 24 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                                                                          customer

#line default
#line hidden
#nullable disable
            , 45, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer = __value, customer), 46, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudText>(47);
                __builder2.AddAttribute(48, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 26 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(50, "Customers");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudToolBarSpacer>(52);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n        ");
                global::__Blazor.MudblazorDemo.CRUD.Pages.Index.TypeInference.CreateMudTextField_4(__builder2, 54, 55, "Search for Customers...", 56, 
#nullable restore
#line 28 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                                                                  Adornment.Start

#line default
#line hidden
#nullable disable
                , 57, 
#nullable restore
#line 28 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                                                                                                   Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                , 58, 
#nullable restore
#line 28 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                                                                                                                                           Size.Medium

#line default
#line hidden
#nullable disable
                , 59, "mt-0", 60, 
#nullable restore
#line 28 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                   searchString

#line default
#line hidden
#nullable disable
                , 61, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString = __value, searchString)));
            }
            , 62, (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTh>(63);
                __builder2.AddAttribute(64, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(65, "ID");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(67);
                __builder2.AddAttribute(68, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(69, "First Name");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\r\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(71);
                __builder2.AddAttribute(72, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(73, "Last Name");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(75);
                __builder2.AddAttribute(76, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(77, "Phone Number");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\r\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(79);
                __builder2.AddAttribute(80, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(81, "State");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "   \r\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(83);
                __builder2.AddAttribute(84, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(85, "City");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "    \r\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudTh>(87);
                __builder2.AddAttribute(88, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(89, "Actions");
                }
                ));
                __builder2.CloseComponent();
            }
            , 90, (context) => (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTd>(91);
                __builder2.AddAttribute(92, "DataLabel", "Id");
                __builder2.AddAttribute(93, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 40 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
__builder3.AddContent(94, context.Id);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(95, "\r\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(96);
                __builder2.AddAttribute(97, "DataLabel", "FirstName");
                __builder2.AddAttribute(98, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 41 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
__builder3.AddContent(99, context.FirstName);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(100, "\r\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(101);
                __builder2.AddAttribute(102, "DataLabel", "LastName");
                __builder2.AddAttribute(103, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 42 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
__builder3.AddContent(104, context.LastName);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(105, "\r\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(106);
                __builder2.AddAttribute(107, "DataLabel", "PhoneNumber");
                __builder2.AddAttribute(108, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 43 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
__builder3.AddContent(109, context.PhoneNumber);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(110, "   \r\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudTd>(111);
                __builder2.AddAttribute(112, "DataLabel", "");
                __builder2.AddAttribute(113, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::MudBlazor.MudFab>(114);
                    __builder3.AddAttribute(115, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                ()=>Edit(@context.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(116, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 45 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                               Color.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(117, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 45 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                                                     Icons.Material.Filled.Edit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(118, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 45 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                                                                                       Size.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(119, "IconSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 45 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                                                                                                             Size.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(120, "\r\n            ");
                    __builder3.OpenComponent<global::MudBlazor.MudFab>(121);
                    __builder3.AddAttribute(122, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                ()=>Delete(@context.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(123, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 46 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                                 Color.Secondary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(124, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 46 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                                                         Icons.Material.Filled.Delete

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(125, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 46 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                                                                                             Size.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(126, "IconSize", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Size>(
#nullable restore
#line 46 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
                                                                                                                                                   Size.Small

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\91908\Source\Repos\MudblazorDemo.CRUD\MudblazorDemo.CRUD\Pages\Index.razor"
      
    private bool hover = false;
    private string searchString = "";

    private Customer customer = new Customer();
    private List<Customer> customers = new List<Customer>();

    protected override async Task OnInitializedAsync()
    {
        GetCustomers();
    }

    private List<Customer> GetCustomers()
    {
        customers = customerService.GetCustomers();
        return customers;
    }
    private bool Search(Customer customer)
    {
        if (string.IsNullOrWhiteSpace(searchString)) return true;
        if (customer.FirstName.Contains(searchString, StringComparison.OrdinalIgnoreCase)
            || customer.LastName.Contains(searchString, StringComparison.OrdinalIgnoreCase)
            || customer.PhoneNumber.Contains(searchString, StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }
        return false;
    }

    private void Save()
    {
        customerService.SaveCustomer(customer);
        customer = new Customer();
        snackBar.Add("Customer Saved.", Severity.Success);
        GetCustomers();
    }

    private void Edit(int id)
    {
        customer = customers.FirstOrDefault(c => c.Id == id);
    }
    private void Delete(int id)
    {
        customerService.DeleteCustomer(id);
        snackBar.Add("Customer Deleted.", Severity.Success);
        GetCustomers();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MudblazorDemo.CRUD.Services.IStateService stateService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MudBlazor.ISnackbar snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MudblazorDemo.CRUD.Services.ICustomerService customerService { get; set; }
    }
}
namespace __Blazor.MudblazorDemo.CRUD.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTable_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Int32 __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<T> __arg1, int __seq2, global::System.Func<T, global::System.Boolean> __arg2, int __seq3, global::System.Object __arg3, int __seq4, global::System.Object __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg7)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Elevation", __arg0);
        __builder.AddAttribute(__seq1, "Items", __arg1);
        __builder.AddAttribute(__seq2, "Filter", __arg2);
        __builder.AddAttribute(__seq3, "customer", __arg3);
        __builder.AddAttribute(__seq4, "customerChanged", __arg4);
        __builder.AddAttribute(__seq5, "ToolBarContent", __arg5);
        __builder.AddAttribute(__seq6, "HeaderContent", __arg6);
        __builder.AddAttribute(__seq7, "RowTemplate", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Adornment __arg1, int __seq2, global::System.String __arg2, int __seq3, global::MudBlazor.Size __arg3, int __seq4, global::System.String __arg4, int __seq5, T __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg6)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "Adornment", __arg1);
        __builder.AddAttribute(__seq2, "AdornmentIcon", __arg2);
        __builder.AddAttribute(__seq3, "IconSize", __arg3);
        __builder.AddAttribute(__seq4, "Class", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

#pragma checksum "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p22-universidadv2/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f94fa7c6839d5c273be79ce326bb7f5f9f31f15f"
// <auto-generated/>
#pragma warning disable 1591
namespace p21_universidadv1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p22-universidadv2/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p22-universidadv2/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p22-universidadv2/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p22-universidadv2/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p22-universidadv2/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p22-universidadv2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p22-universidadv2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p22-universidadv2/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p22-universidadv2/_Imports.razor"
using p21_universidadv1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p22-universidadv2/_Imports.razor"
using p21_universidadv1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p22-universidadv2/Pages/Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p22-universidadv2/Pages/Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "/Volumes/GoogleDrive/Mi unidad/uaz-2021/clases-ad-2021/04-desappinter-ic/programas/p22-universidadv2/Pages/Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Desktop\projet\wow\Client\Pages\Lalala.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae7fac20cdc7fd8cab8c0b211738046783b8480a"
// <auto-generated/>
#pragma warning disable 1591
namespace wow.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Desktop\projet\wow\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Desktop\projet\wow\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Desktop\projet\wow\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Desktop\projet\wow\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Desktop\projet\wow\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Desktop\projet\wow\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Desktop\projet\wow\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Desktop\projet\wow\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Desktop\projet\wow\Client\_Imports.razor"
using wow.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Desktop\projet\wow\Client\_Imports.razor"
using wow.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lalala")]
    public partial class Lalala : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-xwov5agu11>lalala</h3>");
#nullable restore
#line 8 "D:\Desktop\projet\wow\Client\Pages\Lalala.razor"
 if(chiffre == 42)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p b-xwov5agu11>Let\'s go</p>");
#nullable restore
#line 11 "D:\Desktop\projet\wow\Client\Pages\Lalala.razor"
}else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p b-xwov5agu11>pas cool</p>");
#nullable restore
#line 14 "D:\Desktop\projet\wow\Client\Pages\Lalala.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "href", 
#nullable restore
#line 16 "D:\Desktop\projet\wow\Client\Pages\Lalala.razor"
          lien

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "b-xwov5agu11");
            __builder.AddContent(6, "Connexion Bnet ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "D:\Desktop\projet\wow\Client\Pages\Lalala.razor"
       
    int chiffre;
    string lien;
    protected override async Task OnInitializedAsync()
    {

        // quand le composant est pret on execute
        chiffre = await request.GetFromJsonAsync<int>("api/truc/machin");
        lien =  await request.GetFromJsonAsync<string>("api/connection/connexion");

        await base.OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient request { get; set; }
    }
}
#pragma warning restore 1591

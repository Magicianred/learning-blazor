// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SlackClone.Features.Messages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/madebygps/Developer/learning-blazor/SlackClone/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/madebygps/Developer/learning-blazor/SlackClone/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/madebygps/Developer/learning-blazor/SlackClone/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/madebygps/Developer/learning-blazor/SlackClone/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/madebygps/Developer/learning-blazor/SlackClone/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/madebygps/Developer/learning-blazor/SlackClone/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/madebygps/Developer/learning-blazor/SlackClone/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/madebygps/Developer/learning-blazor/SlackClone/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/madebygps/Developer/learning-blazor/SlackClone/_Imports.razor"
using SlackClone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/madebygps/Developer/learning-blazor/SlackClone/_Imports.razor"
using SlackClone.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/madebygps/Developer/learning-blazor/SlackClone/Features/Messages/Home.razor"
using SlackClone.Features.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/madebygps/Developer/learning-blazor/SlackClone/Features/Messages/Home.razor"
using SlackClone.Domain;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/slack")]
    public partial class Home : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "/home/madebygps/Developer/learning-blazor/SlackClone/Features/Messages/Home.razor"
       
    private List<SlackMessage> messages;
    protected override void OnInitialized()
    {
        /*This method is executed at the point your component is 
        initialized, before anything is rendered to the screen, 
        making it the perfect place to retrieve data.*/

        messages = new List<SlackMessage> {

            new SlackMessage{
                Message = "Hello",
                PostedBy = "GPS",
                PostedOn = DateTime.Now
            },
            new SlackMessage{
                Message = "How are you?",
                PostedBy = "Gwyn",
                PostedOn = DateTime.Now
            },
            
            
            };
            
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "/home/madebygps/Developer/learning-blazor/SlackClone/Features/Messages/Message.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86148d2d26992984a271fc7462fa2b60c8bd2690"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "/home/madebygps/Developer/learning-blazor/SlackClone/Features/Messages/Message.razor"
using SlackClone.Domain;

#line default
#line hidden
#nullable disable
    public partial class Message : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-body");
            __builder.OpenElement(4, "div");
            __builder.OpenComponent<SlackClone.Features.Messages.Username>(5);
            __builder.AddAttribute(6, "Name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "/home/madebygps/Developer/learning-blazor/SlackClone/Features/Messages/Message.razor"
                             Details.PostedBy

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\n            ");
            __builder.OpenComponent<SlackClone.Features.Messages.Time>(8);
            __builder.AddAttribute(9, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime>(
#nullable restore
#line 8 "/home/madebygps/Developer/learning-blazor/SlackClone/Features/Messages/Message.razor"
                          Details.PostedOn

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n        ");
            __builder.OpenComponent<SlackClone.Features.Messages.MessageText>(11);
            __builder.AddAttribute(12, "Message", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "/home/madebygps/Developer/learning-blazor/SlackClone/Features/Messages/Message.razor"
                               Details.Message

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "/home/madebygps/Developer/learning-blazor/SlackClone/Features/Messages/Message.razor"
       
    [Parameter]
    public SlackMessage Details {get; set;}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

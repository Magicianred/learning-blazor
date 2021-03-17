#pragma checksum "/home/madebygps/Developer/learning-blazor/SlackClone/Features/PostNew/PostMessage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4af505f13e770a96fd52447681a65bc6ff95d21"
// <auto-generated/>
#pragma warning disable 1591
namespace SlackClone.Features.PostNew
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
#line 1 "/home/madebygps/Developer/learning-blazor/SlackClone/Features/PostNew/PostMessage.razor"
using SlackClone.Domain;

#line default
#line hidden
#nullable disable
    public partial class PostMessage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card my-3");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "/home/madebygps/Developer/learning-blazor/SlackClone/Features/PostNew/PostMessage.razor"
                         NewMessage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "/home/madebygps/Developer/learning-blazor/SlackClone/Features/PostNew/PostMessage.razor"
                                                    HandleSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(10);
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "placeholder", "type something witty here!");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "/home/madebygps/Developer/learning-blazor/SlackClone/Features/PostNew/PostMessage.razor"
                                            NewMessage.Message

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NewMessage.Message = __value, NewMessage.Message))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => NewMessage.Message));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\n            ");
                __builder2.AddMarkupContent(17, "<button class=\"btn btn-primary\">Post</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "/home/madebygps/Developer/learning-blazor/SlackClone/Features/PostNew/PostMessage.razor"
       
    public SlackMessage NewMessage { get; set; } = new SlackMessage();
    [Parameter]
    public EventCallback<SlackMessage> OnPosted { get; set; }
    async Task HandleSubmit()
    {
        NewMessage.PostedBy = "GPS";
        NewMessage.PostedOn = DateTime.Now;
        await OnPosted.InvokeAsync(NewMessage);

        NewMessage = new SlackMessage();

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
using Microsoft.AspNetCore.Components;
using ShoppingCartStarter.Shared.Cart;
using System.Net.Http;
using System.Threading.Tasks;
using ShoppingCartStarter.Shared.Cart.LineItem;
using System.Net.Http.Json;
using System;

namespace ShoppingCartStarter.Client.Pages.Cart 
{
    public class ItemBase : ComponentBase
    {
        [Parameter] 
        public Details.Model.LineItem Details { get; set; }
        [Inject] 
        public HttpClient Http { get; set; }
        [Parameter]
        public EventCallback OnQuantityChanged { get; set; }

        [Parameter] 
        public EventCallback<Details.Model.LineItem> OnDeleted { get; set; }
        protected async Task OnDeleteClicked()
        {
            await Http.DeleteAsync($"api/cart/lines/{Details.Id}");
            await OnDeleted.InvokeAsync(Details);
        }
        protected async Task QuantityChanged(int value)
        {
            await Http.PutAsJsonAsync("api/cart/lines", new Update.Command
            {
                Id = Details.Id,
                Quantity = value
            });

            await OnQuantityChanged.InvokeAsync(EventArgs.Empty);
            
        }
    }
}
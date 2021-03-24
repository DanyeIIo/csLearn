using CafeForDevs.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace CafeForDevs.Client
{
    public class CafeHttpClient : ICafeHttpClient
    {
        private readonly HttpClient _client;
        public CafeHttpClient(HttpClient client, Uri baseUri)
        {   
            _client = client;
            _client.BaseAddress = baseUri;
        }
        public MenuModel GetMenu() 
        {
            var response = _client.GetAsync("menu").Result;
            // formiruem menu iz otveta servera
            var json = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<MenuModel>(json);
        }
        public void SelectMenuItem(int menuItemId,int quantity)
        {
            var req = new MenuItemRequestModel
            {
                MenuItemId = menuItemId,
                Quantity = quantity
            };

            var json = JsonConvert.SerializeObject(req);
            var content = new StringContent(json);
            var response = _client.PostAsync("order", content).Result; 
        }
        public OrderModel GetOrder()
        {
            var res = _client.GetAsync("order").Result;
            var json = res.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<OrderModel>(json);

        }
    }

}

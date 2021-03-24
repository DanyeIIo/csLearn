using CafeForDevs.Models;
using CafeForDevs.Server.Application;
using System.Linq;
using System.Net;

namespace CafeForDevs.Server.Handlers
{
    public class OrderHandler : Handler, IHandler
    {
        private Order _order;
        public string Path => "/order";
        public OrderHandler()
        {
            _order = new Order();
        }
        public void Handle(HttpListenerContext context)
        {
            switch (context.Request.HttpMethod)
            {
                case "POST":

                    var req = GetRequestBody<MenuItemRequestModel>(context);
                    SelectMenuItem(req.MenuItemId, req.Quantity);

                    context.Response.StatusCode = (int)HttpStatusCode.OK;
                    break;
                case "GET":
                    var order = GetOrder();
                    context.Response.StatusCode = (int)HttpStatusCode.OK;
                    SetResponse<OrderModel>(order, context);

                    break;
                default:
                    break;
            };
            context.Response.Close();
        }
        private void SelectMenuItem(int menuItemId, int quantity)
        {
            // polu4it bludo iz menu po menuItemId

            // formiruem novuiu pozitsiu v zakaze
            var menuItem = Menu.Get(menuItemId);
            _order.AddPosition(menuItem, quantity);
        }
        private OrderModel GetOrder()
        {
            // get order
            var order = new OrderModel
            {
                Positions = _order.Positions
                    .Select(x => new OrderPositionModel
                    {
                        Name = x.Name,
                        Price = x.Price,
                        Quantity = x.Quantity
                    })
                    .ToArray()
            };
            return  order;
            // sformirovat order

            // send to client
        }
    }
}

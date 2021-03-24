using CafeForDevs.Models;
using CafeForDevs.Server.Application;
using System;
using System.Linq;
using System.Net;
using System.Text;

namespace CafeForDevs.Server.Handlers
{
    public class MenuHandler : Handler,IHandler
    {
        public string Path => "/menu";

        public void Handle(HttpListenerContext context)
        {
            switch (context.Request.HttpMethod)
            {
                case "GET":
                    var menu = GetMenu();
                    context.Response.StatusCode = (int)HttpStatusCode.OK;
                    SetResponse(menu, context);
                    break;
            };
            context.Response.Close();
        }
        private MenuModel GetMenu()
        {

            var menu = new MenuModel
            {
                Items = Menu.Items
                    .Select(x => new MenuItemModel
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Price = x.Price
                    })
                    .ToArray()
            };
            // take menu
            return menu;
            // sformirovat resultat
            // send to client
        }

    }

}

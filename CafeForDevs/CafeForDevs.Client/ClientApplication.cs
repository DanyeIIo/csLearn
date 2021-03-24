using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace CafeForDevs.Client
{
    internal class ClientApplication
    {
        private ICafeHttpClient _cafeHttpClient;
        public ClientApplication(ICafeHttpClient cafeHttpClient)
        {
            _cafeHttpClient = cafeHttpClient;
        }
        internal void Start()
        {
            Console.WriteLine("Client application has been started");
            var isUserContinue = true;
            string userAnswer;
            do
            {
                Console.WriteLine(@"Choose menu:
1) Output restaurant menu
2) Choose bludo in menu
3) Output information about order
4) Leave in to the program");
                userAnswer = Console.ReadLine();
                switch (userAnswer)
                {
                    case "1":
                        PrintMenu();
                        break;
                    case "2":
                        SelectMenuItem();
                        break;
                    case "3":
                        PrintOrder();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Butede li vi prodolzhat?");
                userAnswer = Console.ReadLine();
                isUserContinue = userAnswer.ToLower() == "y";
            } while (isUserContinue);
        }
        internal void PrintMenu()
        {
            var menu = _cafeHttpClient.GetMenu();
            foreach (var item in menu.Items)
            {
                Console.WriteLine($"{item.Id}: {item.Name} - {item.Price}");
            }
        }
        internal void SelectMenuItem()
        {
            Console.WriteLine("Enter number of bludo");
            var userAnswer = Console.ReadLine();
            var menuItemId = int.Parse(userAnswer); //

            Console.WriteLine("Enter count of bludo");
            userAnswer = Console.ReadLine();
            var quantity = int.Parse(userAnswer); //

            _cafeHttpClient.SelectMenuItem(menuItemId, quantity);

        }
        internal void PrintOrder()
        {
            var order = _cafeHttpClient.GetOrder();
            foreach (var position in order.Positions)
            {
                Console.WriteLine($"{position.Name}: {position.Price} * {position.Quantity} = {position.Sum}");

            }
            var orderTotal = order.Positions.Sum(x => x.Sum);
            Console.WriteLine($"Sum of ur order:{orderTotal}");
        }
    }
}

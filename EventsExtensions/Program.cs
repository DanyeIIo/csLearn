using System;
using System.Collections.Generic;

namespace EventsExtensions
{
    public delegate void Notify(string message); // delegate struktura dannih
    internal class Program
    {
        public static event Notify OnAction; // pole ili svoistvo
        static void Main(string[] args)
        {
            OnAction = Print;
            OnAction?.Invoke("Hello World");
            Cart cart = new Cart();
            cart.AfterItemAdded += Print;
            cart.AfterItemAdded += Print;
            cart.AfterItemAdded += Print;
            cart.AfterItemAdded += Info;
            cart.AfterItemAdded += Info;
            cart.AfterItemAdded += Info;

        }
        private static void Print(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }

    public class Cart
    {
        private List<string> items;
        public Cart()
        {
            items = new List<string>();
        }
        public event Notify BeforeItemAdded;
        public event Notify OnItemAdding;
        public event Notify AfterItemAdded;
        public void AddItem(string item)
        {
            BeforeItemAdded?.Invoke("OnItemAdded" + item);
            if (string.IsNullOrWhiteSpace(item))
            {
                throw new ArgumentException(nameof(item));
            }
            OnItemAdding?.Invoke("OnItemAdding" + item);
            items.Add(item);
            AfterItemAdded?.Invoke("AfterItemAdding" + item);

        }

    }
}

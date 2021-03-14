using System;
using System.Collections.Generic;
using System.Text;
using Models;
using Models.Items;

namespace Models.Showcase
{
    public class Shop : IShowcase, IEntity
    {
        public int Identifier { get; set; } // IShowcase
        public int Volume { get; set; } // IShowcase
        public string Name { get; set; } // IShowcase
        public int Cost 
        { 
            get 
            {
                if (Cost.Equals(0))
                {
                    //todo
                }
                return Cost; // todo
            } 
            set 
            {
                if (value <=0)
                {
                    Console.WriteLine("value can't be less than 0");
                }
                else
                {
                    Cost = value;
                }
            } 
        }
        public DateTime CreatedAt { get; } // IShowcase
        public DateTime RemovedAt { get; } // IShowcase
        //public List<IItem> Items { get => items; } // IShowcase

        //private List<IItem> items = new List<IItem>(); // This
        public Shop(int identifier,int volume,string name) // This
        {
            Identifier = identifier;
            Volume = volume;
            CreatedAt = DateTime.Now;
        }

        public IResult Validate() // IEntity
        {
            IResult result = new Result();
            if (Volume <=0)
            {
                result.Check = false;
                result.Message+= "Volume can not be less and equal to 0";
            }
            if (string.IsNullOrWhiteSpace(Name))
            {
                result.Check = false;
                result.Message += "\nName can not be empty ";
            }
            else if (Name.IsSpace())
            {
                result.Check = false;
                result.Message += "\nName can not contains whiite spaces";
            }
            return result;
        }
    }
}

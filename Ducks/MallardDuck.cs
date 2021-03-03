using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("I m a real duck type of Mallard!");
        }
    }
}

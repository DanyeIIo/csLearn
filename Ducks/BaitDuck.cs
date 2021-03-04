using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    class BaitDuck : Duck
    {
        public BaitDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a bait duck, There is a hunter not far from me! run away!!!");
        }
    }
}

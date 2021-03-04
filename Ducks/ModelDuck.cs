using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack(); 
        }
        public override void Display()
        {
            Console.WriteLine("I m a Model duck");
        }
    }
}

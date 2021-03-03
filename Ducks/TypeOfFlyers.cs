using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying with wings");
        }
    }
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Have no wings");
        }
    }
}

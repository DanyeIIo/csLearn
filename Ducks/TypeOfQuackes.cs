using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    public class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack");
        }
    }
    public class Squeak : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
    public class MuteQuack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {

        }
    }
}

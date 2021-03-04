using System;
using System.Collections.Generic;
using System.Text;

namespace Ducks
{
    public abstract class Duck
    {
        public IQuackBehavior quackBehavior;
        public IFlyBehavior flyBehavior;
        public Duck()
        {
        }
        public abstract void Display();
        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys");
        }
        public void PerformQuack()
        {
            quackBehavior.Quack();
        }
        public void PerformFly()
        {
            flyBehavior.Fly();
        }
        public void SetFlyBehavior(IFlyBehavior fly)
        {
            flyBehavior = fly;
        }
        public void SetQuackBehavior(IQuackBehavior quack)
        {
            quackBehavior = quack;
        }
    }
}

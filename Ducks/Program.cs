using System;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();
            //
            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
            //
            Duck hunterDuck = new BaitDuck();
            hunterDuck.PerformFly();
            hunterDuck.PerformQuack();
        }
    }
}

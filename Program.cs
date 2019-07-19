using System;

namespace interfaces
{
    class Program
    {

        static void Main(string[] args)
        {
            HoldingTank SwimmingAnimalsCleaningDay = new HoldingTank(
            );
            SwimmingAnimalsCleaningDay.SwimmingAnimals.Add(
                new Terrapin("Susie")
            );
            SwimmingAnimalsCleaningDay.SwimmingAnimals.Add(
                 new Betta("David")
            );
            FlyingAviary FlyingAnimalsCleaningDay = new FlyingAviary(
            );
            FlyingAnimalsCleaningDay.FlyingAnimals.Add(
                new Parakeet("Chathulu")
            );
            FlyingAnimalsCleaningDay.FlyingAnimals.Add(
                new Finch("Jesus")
            );
            DiggingTank DiggingAnimalsCleaningDay = new DiggingTank(
            );
            DiggingAnimalsCleaningDay.DiggingAnimals.Add(
               new Earthworm("Romulus")
            );
            DiggingAnimalsCleaningDay.DiggingAnimals.Add(
               new Gerbil("Lil Dude")
            );
            DiggingAnimalsCleaningDay.DiggingAnimals.Add(
               new Mouse("Mousey Mc Mouseface")
            );
            DiggingAnimalsCleaningDay.DiggingAnimals.Add(
                  new Ant("Hercules")
            );
            LandHolding LandHoldingCleaningDay = new LandHolding(
            );
            LandHoldingCleaningDay.LandAnimals.Add(
                new Copperhead("Pointy Mouth")
            );
            LandHoldingCleaningDay.LandAnimals.Add(
                new TimberRattlesnake("Bitey face")
            );

            Console.WriteLine("-------WATCH THEM WALK--------");
            foreach (IWalking animal in LandHoldingCleaningDay.LandAnimals)
            {
                animal.walk();
            }
            Console.WriteLine("-------WATCH THEM RUN--------");
             foreach (IWalking animal in LandHoldingCleaningDay.LandAnimals)
            {
                animal.run();
            }
             Console.WriteLine("-------WATCH THEM FLY--------");
             foreach (IFlying animal in FlyingAnimalsCleaningDay.FlyingAnimals)
             {
                 animal.fly();
             }
             Console.WriteLine("-------WATCH THEM LAND--------");
              foreach (IFlying animal in FlyingAnimalsCleaningDay.FlyingAnimals)
             {
                 animal.land();
             }
             Console.WriteLine("-------WATCH THEM SWIM--------");
             foreach (ISwimming  animal in SwimmingAnimalsCleaningDay.SwimmingAnimals)
             {
                 animal.swim();
             }
              Console.WriteLine("-------WATCH THEM DIG--------");
            foreach (IDigging animal in DiggingAnimalsCleaningDay.DiggingAnimals)
            {
                animal.dig();
            }
        }

    }
}

using System;

namespace interfaces {

        public class Gerbil: IWalking, IDigging{
            private string _name {get; set;}

            public Gerbil(string name)
        {
                _name = name;
        }

            public void walk(){
                Console.WriteLine($"{_name} the lil gerbil is walking");
            }

            public void run(){
                Console.WriteLine($"{_name} is runnin with lil gerbil feet");
            }

            public void dig(){
                Console.WriteLine($"{_name} is digging just like a lil Gerbil should");
            }
        }
}
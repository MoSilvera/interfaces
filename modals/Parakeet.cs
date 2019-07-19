using System;

namespace interfaces {
 public class Parakeet : IFlying, IWalking {

            private string _name {get; set;}

            public Parakeet(string name){
                _name = name;
            }

            public void walk() {
                Console.WriteLine($"{_name} the parakeet is so cute walking with lil bird legs");

            }

            public void run(){
                Console.WriteLine($"{_name} the parakeet is running...well hopping. Parakeets hop");
            }
            public void fly (){
                Console.WriteLine($"{_name} the parakeet is flying");
            }

            public void land() {
                Console.WriteLine($"{_name} the parakeet is landing");
            }
        }
}
using System;
namespace interfaces {
    public class Finch: IFlying, IWalking {
        private string _name;

        public Finch(string name) {
            _name =name;
        }

        public void fly(){
         Console.WriteLine($"{_name} the finch is flying!");

        }

        public void land(){
            Console.WriteLine($"{_name} the finch is landing");
        }

        public void walk() {
            Console.WriteLine($"{_name} the finch is walking with lil bird legs");
        }
        public void run(){
            Console.WriteLine($"{_name} the finch is running with his lil bird lets");
        }
    }

}
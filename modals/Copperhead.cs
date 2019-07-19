using System;

namespace interfaces {
     public class Copperhead: IWalking {
             private string _name {get; set;}

            public Copperhead(string name)
        {
                _name = name;
        }

        public void walk(){
            Console.WriteLine($"{_name} the copperhead is slithering");
        }

        public void run(){
            Console.WriteLine($"{_name} the copperhead is slithering real fast");
        }
        }

}
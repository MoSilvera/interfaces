using System;

namespace interfaces {

        public class Mouse: IWalking, IDigging{
            private string _name {get; set;}

            public Mouse(string name)
        {
                _name = name;
        }

            public void walk(){
                Console.WriteLine($"{_name} the lil mouse is walking");
            }

            public void run(){
                Console.WriteLine($"{_name} is runnin with lil mouse feet");
            }

            public void dig(){
                Console.WriteLine($"{_name} is digging just like a lil Mouse should");
            }
        }

            
}
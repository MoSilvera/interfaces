using System;

namespace interfaces {
     public class TimberRattlesnake: IWalking {
             private string _name {get; set;}

            public TimberRattlesnake(string name)
        {
                _name = name;
        }

        public void walk(){
            Console.WriteLine($"{_name} is a damn rattlesnake and is slithering");
        }

        public void run(){
            Console.WriteLine($"{_name} is a damn rattlesnake and is slithering real fast");
        }
        }

}
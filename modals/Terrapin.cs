using System;

namespace interfaces {
    public class Terrapin: ISwimming, IWalking
        {

        public void walk(){
            Console.WriteLine($"{_name} is walkin with his lil terrapin flippers");
        }

        public void run(){
            Console.WriteLine($"{_name} is running....well as fast as a terrapin can run anyway");
        }

        private string _name {get; set;}

        public Terrapin(string name)
        {
                _name = name;
        }
        public int MaximumDepth {get;} = 100;

        public void swim(){
            Console.WriteLine($"{_name} the Terrapin is swimming with lil swimmy flippers");
        }

        }
}
using System;

namespace interfaces
{
    public class Ant: IWalking, IDigging{
                private string _name {get; set;}

            public Ant(string name)
        {
                _name = name;
        }

            public void walk(){
                Console.WriteLine($"{_name} is walking. They're is an ant so there are probably other Ants"); 
            }

            public void run(){
                Console.WriteLine($"{_name}is running. It looks a lot like walking cause ants are always fast");
            }

            public void dig(){
                Console.WriteLine($"{_name} is digging just like a lil ant should");
            }

        }
}
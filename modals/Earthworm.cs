using System;

namespace interfaces {
    public class Earthworm: IDigging {

            private string _name {get; set;}

             public Earthworm(string name){
                _name = name;
            }
            public void dig()
            {
                Console.WriteLine($"{_name} is digging however a worm digs");
            }
        }
}
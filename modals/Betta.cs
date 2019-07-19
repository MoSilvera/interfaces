using System;
namespace interfaces {
    public class Betta: ISwimming{

            private string _name {get; set;}

            public Betta(string name){
                _name = name;
            }
            public void swim(){
                Console.WriteLine($"{_name} is swimming because...betta fish. You are not surprised");
            }

            public int MaximumDepth {get; set;}= 10;


    }
}
using System;

namespace Module_6_OOP  
{
    class Program
    {
        static void Main(string[] args)
        {
            //create objects
            Animal myAnimal = new Animal("green", "6kg", "56", "5");

            myAnimal.printAnimal();
            
            Console.WriteLine("");
            Console.ReadLine();
        }
        
    }
}

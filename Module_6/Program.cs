using System;

namespace Module_6_OOP  
{
    class Program
    {
        static void Main(string[] args)
        {
            //create objects
            Animal myAnimal = new Animal("green", "6kg", "56", 13);
            
            Console.WriteLine("The animal's eye color: {0};\nIt weights: {1};\nIts height is {2} cm; \n " +
                "It is {3} years old.", myAnimal.EyeColor, myAnimal.Weight, myAnimal.Height, myAnimal.Age);

            ChangeEyeColor(myAnimal);

            Console.WriteLine("The animal's eye color: {0};\nIt weights: {1};\nIts height is {2} cm; \n " +
                "It is {3} years old.", myAnimal.EyeColor, myAnimal.Weight, myAnimal.Height, myAnimal.Age);



            public string ChangeEyeColor(Animal.myAnimal) => myAnimal.EyeColor = "brown";









            Console.WriteLine("");
            Console.ReadLine();
        }
        
    }
}

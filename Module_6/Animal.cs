using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6_OOP
{
    public class Animal
    {
        private string eyeColor; //fields, written in camel case
        private string weight;
        private string height;
        private string age;

        //constructor:
        public Animal(string eyeColor, string weight, string height, string age) //to qualify fields
        {
            
            this.eyeColor = eyeColor;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }
        

        public string EyeColor //property, starst with CapitalLetter
        {
            get { return eyeColor; }
            set { eyeColor = value; }
        }
        public string Height
        {
            get { return height ; }
            set { height = value; }
        }
        public string Weight
        {
            get {return weight; }
            set {weight = value; }
        }
        public string Age
        {
            get {return age; }
            set {age = value; }
        }
        public void printAnimal()
        {
            Console.WriteLine("The animal's eye color: {0};\nIt weights: {1};\nIts height is {2} cm; \n It is {3} years old.", eyeColor, weight, height, age);

        }
        private static string ChangeEyeColor()
        {
            return "black";
        }
        private static string ChangeHeight()
        {
            return "122cm";
        }

        private static string SetAge()
        {
            return "15";
        }   


    }
}

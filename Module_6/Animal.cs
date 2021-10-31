using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6_OOP
{
    public class Animal
    {
        private string eyeColor; //fields, written in camel case or _camelCase
        private string weight;
        private string height;
        private int age;

        //constructor starts here
        public Animal(string eyeColor, string weight, string height, int age) //to set fields
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
        public int Age
        {
            get { return age;}
            set { age = value; }
            //get
            //{
            //    return age;   
            //}

            //set
            //{
            //    if (value >= 15)
            //    {
            //        age = value;
            //    }
            //    else
            //    {
            //        Console.WriteLine(0);
            //    }
            //}
        }
        //public void printAnimal()
        //{
        //    Console.WriteLine("The animal's eye color: {0};\nIt weights: {1};\nIts height is {2} cm; \n It is {3} years old.", eyeColor, weight, height, age);

        //}
        public string ChangeEyeColor()
        {
            return eyeColor;
        }

        public string ChangeHeight()
        {
            return height;
        }

        public void SetAge(int newAge)
        {
            if (newAge >= 15)
            {
                age = newAge;
            }
            else
            {
                Console.WriteLine(0);
            }

        }


    }
}

using System;

namespace dogName_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //declared and initialized a variable
            //camelCase for the variable name
            //explicit typing
            string dogName = "Max";
            int dogAge = 7;
            char nickName = 'k';
            
            bool isLoco = true;
            double tennisBalls = 95;
            decimal weight = 50.3m;
            //declared and initialized a variable


            //Console.WriteLine($"My dog's name is {dogName}. He is {dogAge} years old" + 
               //"and he has { tennisBalls} tennis balls and it is { lovesHiking } that he loves to hike");

            string firstVariable = "Max";
            string secondVariable = "John";

            //Console.WriteLine(firstVariable + " " + secondVariable);
            Console.WriteLine($"{firstVariable} {secondVariable}");


        }
    }
}
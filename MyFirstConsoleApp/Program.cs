using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            const int theNumberFive = 5;

            int myFirstInteger;
            myFirstInteger = 12;


            decimal money = 12.50m;
            double moreDecimalStuff = 12.50;
            float floatingPoint = 12.50f;


            bool myFirstBoolean = true;

            var myFirstString = "This is a string...";

            char oneCharacter = myFirstString[2];

            DateTime today = DateTime.Now;

            var poem = @"Roses are red, 
                       violets are blue, 
                       csharp is great,
                       and so are you.";

            var name = "Jose";
            var age = 18;
            var greeting = $"My name is {name} and I am {age} years old.";

            // boxing is bad
            object myNumber = 1;
            myNumber = "stuff";

            var steve = new {Name = "Steve"};

            greeting = $"My name is {steve.Name} and I am {age} years old.";

            var names = new string[10];
            names[0] = "Dylan";
            names[1] = "Todd";
            Console.WriteLine(names[4]);
            Console.WriteLine(names[0]);
            names[10] = "Anca";

            Console.WriteLine(greeting);

        }
    }
}

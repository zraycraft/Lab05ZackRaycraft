using System;

namespace Lab05ZackRaycraft
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //The single-selection if statement runs once if the condition is correct. A while repetition statement will run if the statment is corrct, and will keep checking if its it true after. If it is, it will continue looping until the statement becomes false.
            /*
            int speedLimit = 35;
            int speed = 42;

            if(speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW");
            }

            bool isTrue = true;
            //bool isTrue = false;

            if (isTrue == true)
            {
                Console.WriteLine("It is True!");
            }
            else
            {
                Console.WriteLine("It is False!");
            }

            Console.WriteLine("Please enter the temperature in Fahrenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32d) * 5d / 9d;
            if (fahrenheit < 40 )
            {
                Console.WriteLine("It's Cold! The temperature in celsius is " + celsius);

            }

            else if (fahrenheit > 90)
            {
                Console.WriteLine("It's Hot! The temperature in celsius is " + celsius);
            }

            else
            {
                Console.WriteLine("The temperature in celsius is " + celsius);
            }


            int i = 1;
            while (i < 11 )
            {
                Console.WriteLine(i);
                i++;
            }
           
            int i = 60;
            while(i > 19)
            {
                Console.WriteLine(i);
                i--;
            }
            */

            int i = 10;
            while (i < 21)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}

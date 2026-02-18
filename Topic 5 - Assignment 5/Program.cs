﻿namespace Assignment_5___If_statements
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            spaceboxing();
            Calculator();
            Miniquiz();
        }


        public static void Calculator()
        {
            double number2 = 0;
            double number1;
            double squareRoot;
            string mathoperator;



            //Simple Calculator
            Console.WriteLine();
            Console.WriteLine("Select one of the following: (+, -, x, /, sqrt) ");
            mathoperator = Console.ReadLine()!;

            Console.WriteLine();
            Console.WriteLine("Enter number 1: ");
            double.TryParse(Console.ReadLine(), out number1);
            squareRoot = Math.Sqrt(number1);

            Console.WriteLine();

            if (mathoperator != "sqrt")
            {
                Console.WriteLine("Enter number 2: ");
                double.TryParse(Console.ReadLine(), out number2);
            }

            

            if (mathoperator == "+")
            {
                Console.WriteLine(number1 + " + " + number2 + (" = ") + (number1 + number2));
            }

            else if (mathoperator == "-")
            {
                Console.WriteLine(number1 + " - " + number2 + (" = ") + (number1 - number2));
            }

            else if (mathoperator == "x")
            {
                Console.WriteLine(number1 + " x " + number2 + (" = ") + (number1 * number2));
            }

            else if (mathoperator == "/")
            {
                Console.WriteLine(number1 + " / " + number2 + (" = ") + (number1 / number2));
            }

            else if (mathoperator == "sqrt")
            {
                Console.WriteLine("sqrt of " + number1 + (" = ") + (squareRoot));
            }

        }

        public static void spaceboxing()
        //Space Boxing

        {
            Console.WriteLine("Please enter your current weight: ");
            int weight;
            Int32.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine();

            Console.WriteLine("I have information for the following planets: ");
            Console.WriteLine();
            Console.Write("1. Venus     2. Mars     3. Jupiter");
            Console.WriteLine();
            Console.Write("4. Saturn    5. Uranus   6. Neptune");
            Console.WriteLine();
            Console.WriteLine("Which planet are you visiting: ");

            int planet;
            Int32.TryParse(Console.ReadLine(), out planet);
            if (planet == 1)
            {
                double venusweight = weight * 0.78;
                Console.WriteLine("Your weight would be " + venusweight + " pounds on that planet.");
            }

            else if (planet == 2)
            {
                double marsweight = weight * 0.39;
                Console.WriteLine("Your weight would be " + marsweight + " pounds on that planet.");
            }

            else if (planet == 3)
            {
                double jupitarweight = weight * 2.65;
                Console.WriteLine("Your weight would be " + jupitarweight + " pounds on that planet.");
            }

            else if (planet == 4)
            {
                double saturnweight = weight * 1.17;
                Console.WriteLine("Your weight would be " + saturnweight + " pounds on that planet.");
            }

            else if (planet == 5)
            {
                double uranusweight = weight * 1.05;
                Console.WriteLine("Your weight would be " + uranusweight + " pounds on that planet.");
            }

            else if (planet == 6)
            {
                double neptuneweight = weight * 1.23;
                Console.WriteLine("Your weight would be " + neptuneweight + " pounds on that planet.");
            }
        }

            public static void Miniquiz()
        //Mini Quiz

        {
            Console.WriteLine("hi");
        }

    }
}

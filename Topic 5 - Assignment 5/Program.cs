namespace Assignment_5___If_statements
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
            int score = 0;
            int totalquestions = 4;

            Console.WriteLine("Welcome to my mini quiz");
            Console.WriteLine();

            Console.WriteLine("Question 1: What's 9 x 9?");
            int q1;
            Int32.TryParse(Console.ReadLine(), out q1);

            if (q1 == 81)
            {
                Console.WriteLine("Correct!");
                score = score + 1;
            }
            else if (q1 < 81)
            {
                Console.WriteLine("Incorrect, too low.");
            }
            else
            {
                Console.WriteLine("Incorrect, too high.");
            }

            Console.WriteLine();

            Console.WriteLine("Question 2: Enter a temperature in Celsius where water is liquid.");
            double temp;
            double.TryParse(Console.ReadLine(), out temp);

            if (temp >= 0 && temp <= 99)
            {
                Console.WriteLine("Correct!");
                score = score + 1;
            }
            else if (temp <= 0)
            {
                Console.WriteLine("Incorrect, that is freezing or below.");
            }
            else
            {
                Console.WriteLine("Incorrect, that is boiling or above.");
            }

            Console.WriteLine();

            Console.WriteLine("Question 3: What planet do we live on?");
            string planet = Console.ReadLine();
            planet = planet.ToUpper();

            if (planet == "EARTH")
            {
                Console.WriteLine("Correct!");
                score = score + 1;
            }
            else
            {
                Console.WriteLine("Incorrect, the answer is Earth.");
            }

            Console.WriteLine();

            Console.WriteLine("Question 4: Which one is a primary color?");
            Console.WriteLine("A. Green");
            Console.WriteLine("B. Purple");
            Console.WriteLine("C. Blue");
            Console.WriteLine("D. Pink");

            string choice = Console.ReadLine();
            choice = choice.ToUpper();

            if (choice == "C")
            {
                Console.WriteLine("Correct!");
                score = score + 1;
            }
            else if (choice == "A")
            {
                Console.WriteLine("Incorrect, green is made from blue and yellow.");
            }
            else if (choice == "B")
            {
                Console.WriteLine("Incorrect, purple is made from red and blue.");
            }
            else if (choice == "D")
            {
                Console.WriteLine("Incorrect, pink is a shade of red.");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            Console.WriteLine();

            double percent = (double)score / totalquestions * 100;

            Console.WriteLine("You got " + score + " out of " + totalquestions + ".");
            Console.WriteLine("That is a score of " + percent + " percent.");

            if (score == 0)
            {
                Console.WriteLine("You got 0. Try again!");
            }
            else if (score == totalquestions)
            {
                Console.WriteLine("Perfect score!");
            }
            else
            {
                Console.WriteLine("Good job!");
            }
        }

    }

}

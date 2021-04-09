using System;

namespace Exercise_13_14_15
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                //Exercise 13
                Console.WriteLine("Exercise 13 \nPlease enter a whole number!");

                int number;


                string input = Console.ReadLine();
                bool inputParse = int.TryParse(input, out number);
                if (!inputParse)
                {
                    Console.WriteLine("Please enter whole numbers only!");
                }

                //for loop
                for (int i = 1; i <= number + 1; i++)
                {
                    Console.WriteLine($"{number + 1 - i}");
                }
 
                //continue?
                bool conLoop = true;
                while (conLoop)
                {
                    Console.WriteLine("Would you like to continue? y/n");
                    string conAnswer = Console.ReadLine().ToLower();

                    if (conAnswer == "y")
                    {
                        repeat = true;
                        conLoop = false;
                    }
                    else if (conAnswer == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        repeat = false;
                        conLoop = false;
                    }
                    else
                    {
                        Console.WriteLine("I didn't quite catch that");
                        conLoop = true;
                    }
                }
            }


            //Exercise 14
            bool repeat2 = true;
            while (repeat2)
            {
                Console.WriteLine("Exercise 14 \nPlease enter a whole number!");
                int number2;
                string input2 = Console.ReadLine();
                bool inputParse2 = int.TryParse(input2, out number2);
                if (!inputParse2)
                {
                    Console.WriteLine("Please enter whole numbers only!");
                }

                //for loop
                for (int o = 1; o <= number2; o++)
                {
                    Console.WriteLine($"{o * o}");
                }

                //continue?
                bool conLoop2 = true;
                while (conLoop2)
                {
                    Console.WriteLine("Would you like to continue? y/n");
                    string conAnswer2 = Console.ReadLine().ToLower();

                    if (conAnswer2 == "y")
                    {
                        repeat2 = true;
                        conLoop2 = false;
                    }
                    else if (conAnswer2 == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        repeat2 = false;
                        conLoop2 = false;
                    }
                    else
                    {
                        Console.WriteLine("I didn't quite catch that");
                        conLoop2 = true;
                    }
                }
            }


            //Exercise 15
            bool repeat3 = true;
            while (repeat3)
            {
                Console.WriteLine("Exercise 15 \nPlease enter a whole number!");
                int number3;
                string input3 = Console.ReadLine();
                bool inputParse3 = int.TryParse(input3, out number3);
                if (!inputParse3)
                {
                    Console.WriteLine("Please enter whole numbers only!");
                }

                //for loop
                for (int p = 1; p <= number3; p++)
                {
                    Console.WriteLine($"{p * p * p}");
                }

                //continue?
                bool conLoop3 = true;
                while (conLoop3)
                {
                    Console.WriteLine("Would you like to continue? y/n");
                    string conAnswer3 = Console.ReadLine().ToLower();

                    if (conAnswer3 == "y")
                    {
                        repeat3 = true;
                        conLoop3 = false;
                    }
                    else if (conAnswer3 == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        repeat3 = false;
                        conLoop3 = false;
                    }
                    else
                    {
                        Console.WriteLine("I didn't quite catch that");
                        conLoop3 = true;
                    }
                }
            }
        }
    }
}

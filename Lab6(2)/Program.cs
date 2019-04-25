using System;

namespace Lab6_2_
{
    class Program
    {
        public static void Main(string[] args)
        {
            Boolean run = true;
          
            
            while (run == true)
            {
                Console.WriteLine("Welcome to the Grand Circus Casino!\n");
                Console.WriteLine("Please enter the number of sides of dice: ");
                string input = Console.ReadLine();
                int inputSides = int.Parse(input);
                Console.WriteLine("Please enter the number of dice: ");
                input = Console.ReadLine();
                int inputDice = int.Parse(input);
                Console.WriteLine();


                //int num = int.Parse(input);
                //Console.WriteLine(GetRandom(num));
                Console.Write("You rolled: ");
                Console.WriteLine(Roll(inputSides, inputDice));
                //Console.WriteLine(Roll(dice));
           
                run = Continue();
            }

        }
        public static int GetRandom(int i)
        {
            Random r= new Random();
            int result = r.Next(1, i + 1);
            return result;
        }
        public static int Roll(int sides, int dice)
        {
            int loops = 0;
            int result = 0;
            while (loops < dice)
            {
                
                
                result = result + GetRandom(sides);


                //GetRandom(dice);
                //dice = int.Parse((Console.ReadLine()));
                //int result1 = dice;
                //return result1;
                loops++;
            }
            return result;
        }

        public static Boolean Continue()
        {
            Console.WriteLine("Continue? y/n");
            string input = Console.ReadLine();
            Boolean run = false;
            input.ToLower();

            if (input == "n")
            {
                Console.WriteLine("Good bye");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("I'm sorry I didn't understand your input. Let's try that again");
                run = Continue();
            }

            return run;
        }
    }
}


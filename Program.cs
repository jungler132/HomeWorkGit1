using System;

namespace HomeWorkGit1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thank you for using my programm <3!!!");
            Data();
        }
        public static void Data()
        {
            Console.WriteLine("Input 1-st person name");
            string name_1 = Console.ReadLine();
            Console.WriteLine("Input 1-st person age");
            int age_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input 2-st person name");
            string name_2 = Console.ReadLine();
            Console.WriteLine("Input 2-st person age");
            int age_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input name who older");
            string name_console = Console.ReadLine();
            correctData(name_1, age_1, name_2, age_2, name_console);
            name_1IfRight(name_1, age_1, name_2, age_2, name_console);
            name_2IfRight(name_1, age_1, name_2, age_2, name_console);
        }
        public static void correctData(string name_1, int age_1, string name_2, int age_2, string name_console)
        {

            if (name_1 != name_console && name_2 != name_console)
            {
                Console.WriteLine("Input right \"Name\".");
                Data();
            }
            else if (age_1 <= 0 || age_2 <= 0)
            {
                Console.WriteLine("Input right \"Age\".");
                Data();
            }

        }
        public static void name_1IfRight(string name_1, int age_1, string name_2, int age_2, string name_console)
        {
            if (name_1 == name_console)
            {
                if (age_1 > age_2)
                {
                    Console.WriteLine("Right");
                }
                else if (age_1 == age_2)
                {
                    Console.WriteLine("They same age");
                }
                else if (age_1 < age_2)
                {
                    int age_difference = age_2 - age_1;
                    Console.WriteLine("Wrong");
                    Console.WriteLine($"{name_2} older than {name_1}--{age_difference} ");
                }
            }
        }
        public static void name_2IfRight(string name_1, int age_1, string name_2, int age_2, string name_console)
        {
            if (name_2 == name_console)
            {
                if (age_2 > age_1)
                {
                    Console.WriteLine("Right");
                }
                else if (age_2 == age_1)
                {
                    Console.WriteLine("They same age");
                }
                else if (age_2 < age_1)
                {
                    int age_difference = age_1 - age_2;
                    Console.WriteLine("Wrong");
                    Console.WriteLine($"{name_1} older than {name_2}--{age_difference} ");
                }
            }
        }
    }
}

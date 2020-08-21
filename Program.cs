using System;

namespace HomeWorkGit1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        
        //Домашнее задание Homework4
            //1 Задание-Написать программу, которая будет спрашивать имя и возраст двух человек.
            Console.WriteLine("Input 1-st person`s name and age.");
            string name_1 = Console.ReadLine();
            int age_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input 2-st person`s name and age.");
            string name_2 = Console.ReadLine();
            int age_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Who`s older");

            string name_console = "";
            while (name_console != name_1 || name_console != name_2)
            {
                name_console = Console.ReadLine();
                if (name_1 == name_console)
                {
                    if (age_1 > age_2)
                    {
                        Console.WriteLine("Right answer");
                    }
                    else if (age_1 == age_2)
                    {
                        Console.WriteLine("They same age");
                    }
                    else if (age_2 > age_1)
                    {
                        int raznica = age_2 - age_1;
                        Console.WriteLine("Wrong asnwer");
                        Console.WriteLine($"{name_2} older than {name_1}  {raznica} years.");
                    }
                    else
                    {
                        Console.WriteLine("ERROR");
                    }
                }
                if (name_2 == name_console)
                {
                    if (age_2 >= age_1)
                    {
                        Console.WriteLine("Right answer");
                    }
                    else if (age_2 == age_1)
                    {
                        Console.WriteLine("They same age");
                    }
                    else if (age_2 < age_1)
                    {
                        int raznica_2 = age_1 - age_2;
                        Console.WriteLine("Wrong asnwer");
                        Console.WriteLine($"{name_1} older than {name_2}  {raznica_2} age.");
                    }
                    else
                    {
                        Console.WriteLine("ERROR");
                    }
                }
                else if (name_console != name_2 && name_console != name_1)
                {
                    Console.WriteLine("Input data again.");
                }
            }
        }
    }
}

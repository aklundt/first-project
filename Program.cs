using System;

namespace first_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console: Is Harambe alive?");
            Console.WriteLine("1.) Yes 2.) No)");
            Console.WriteLine("");
            string HarAl = Console.ReadLine();
            if (HarAl == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("Console: Yay!");
                Console.WriteLine("END");
            }
            else if (HarAl == "2")
            {
                Console.WriteLine("");
                Console.WriteLine("Console: NOOOO!!");
                Console.WriteLine("");
                Console.WriteLine("*Console the console.*");
                Console.WriteLine("1.) There there 2.) Whatever");
                string conCon = Console.ReadLine();
                if (conCon == "1")
                {
                    Console.WriteLine("");
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine("Console: Thanks, Friend");
                    Console.WriteLine("END");
                }
                else if (conCon == "2")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Console: What?");
                    Console.WriteLine("1.) He's just a monkey. 2.) I worked with him; He was a jerk.");
                    string whatevs = Console.ReadLine();
                    if (whatevs == "1")
                    {
                        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                        Console.WriteLine("END");
                        Console.WriteLine("Console: HE'S A GORILLA!!!!");
                    }
                    else if (whatevs == "2")
                    {
                        Console.WriteLine("Console: You WORKED with HIM!! Lucky!");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                        Console.WriteLine("END");
                        Console.WriteLine("Console: What?");
                    };
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Console: What?");
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine("END");
                };
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Console: What?");
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("END");
            };
        }
    }
}
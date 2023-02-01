using System;
using MethodsExercise;

namespace MethodsExercise
{
	public class Program
	{
        static void Main()
        {
           Console.WriteLine("Exercise 1");




           Console.WriteLine("What is your name?");
           string? name = Console.ReadLine();

           Console.WriteLine("What is your favorite color?");
           string? color = Console.ReadLine();

           Console.WriteLine("What is your favorite hobby?");
           string? hobby = Console.ReadLine();

           Console.WriteLine("What do you do for work?");
           string? job = Console.ReadLine();

           Console.WriteLine("What is your favorite vacation spot?");
           string? vacation = Console.ReadLine();

           Console.WriteLine("What is your best friends name?");
           string? bffName = Console.ReadLine();




            Console.WriteLine($"Hey {name}!");

            Console.WriteLine($"We are going to paint your house {color}.");

            Console.WriteLine($"After we are finished we can go {hobby}.");

            Console.WriteLine($"I know you have to get up early in the morning. {job} is a demanding line of work!");

            Console.WriteLine($"At least you can reward yourself next weekend when go to {vacation} with {bffName}.");







            Console.WriteLine("Exercise 2");




            int answer1 = Methods.Add(5, 8);

            Console.WriteLine(answer1);



            int answer2 = Methods.Sub(50, 17);

            Console.WriteLine(answer2);



            int answer3 = Methods.Divide(150, 6);
            Console.WriteLine(answer3);





            int answer4 = Methods.Multiply(7, 7);
            Console.WriteLine(answer4);
        }

    }
}


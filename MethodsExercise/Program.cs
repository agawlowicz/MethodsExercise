using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            MadLib();
            Operations();
        }
        public static void MadLib()
        {
            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter a friend's name");
            var friend = Console.ReadLine();
            Console.WriteLine("Enter your hometown");
            var hometown = Console.ReadLine();
            Console.WriteLine("Name a place you want to visit");
            var place1 = Console.ReadLine();
            Console.WriteLine("Name a second place you want to visit");
            var place2 = Console.ReadLine();
            Console.WriteLine("Enter an activity you want to try");
            var activity = Console.ReadLine();
            Console.WriteLine("Enter a food you want to try");
            var food = Console.ReadLine();

            Console.WriteLine($"{name} discovered a new form of high speed travel and used" +
                $" this to adventure the world with their friends. {name} went to {place1} and" +
                $" together with {friend}, they tried {activity}. {name} has always wanted to see {place2} and" +
                $" try {food}. He completed his journey when he arrived home in {hometown}.");
        }

        public static void Operations()
        {
            Console.WriteLine("Enter an integer value for x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an integer value for y");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"For x = {x} and y = {y}, the sum = {Add(x,y)}.\nThe difference = {Subtract(x, y)}.\n" +
                $"The product is {Multiply(x, y)}.\nThe quotient is {Divide(x, y)} with a remainder of {Modulus(x, y)}.");
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            return x / y;
        }

        public static int Modulus(int x, int y)
        {
            return x % y;
        }

        //multiple parameters
        public static int Sum(params int[] nums)
        {
            var summation = 0;
            foreach (var x in nums)
            {
                summation += x;
            }

            return summation
        }
    }
}
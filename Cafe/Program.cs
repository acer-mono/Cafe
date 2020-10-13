using System;

namespace Cafe
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Вы не ввели время приема пищи!");
                return;
            }
            
            var cafe = new Cafe();
            try
            {
                var meal = cafe.GetMeal(args[0]);
                Console.WriteLine(meal.GetMenu());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
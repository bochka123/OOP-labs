using System;
using System.Linq;
/*
* Oleksandr Tkach
* number of the score book - 328
* C13 - 9  
*/
namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommonVegetable common1 = new CommonVegetable("Potato", 86, 11, 300);
            CommonVegetable common2 = new CommonVegetable("Cucumber", 16, 13, 200);

            ExoticVegetable exotic2 = new ExoticVegetable("BlackTomato", 24, 175, 155);
            ExoticVegetable exotic1 = new ExoticVegetable("PurpleCarrot", 45, 160, 180);

            SemiExoticVegetable semiExotic1 = new SemiExoticVegetable("SweetPotato", 86, 115, 300);
            SemiExoticVegetable semiExotic2 = new SemiExoticVegetable("Asparagus", 20, 135, 20);

            Vegetable[] salad = { common1, common2, semiExotic1, semiExotic2, exotic1, exotic2 };
            Console.Write("We have salad from such ingradients: ");
            for(int i = 0; i < salad.Length; i++)
            {
                Console.Write(i != salad.Length-1 ? $"{salad[i].name}, " : salad[i].name);
            }
            Console.WriteLine();
            Console.WriteLine();
            int allCalories = 0;
            foreach(Vegetable vegetable in salad)
            {
                allCalories+= vegetable.calorie;
            }
            Console.WriteLine($"Total calories of salad: {allCalories}");
            Console.WriteLine();
            var sortedPrice = salad.OrderBy(vegetable => vegetable.price).ToArray();
            Console.WriteLine("Sorting of price by growing: ");
            foreach (Vegetable vegetable in sortedPrice)
            {
                Console.WriteLine($"{vegetable.name}: {vegetable.price}");
            }
            Console.WriteLine();
            Console.WriteLine("You can write a certain range of caloric content and find out which vegetable(s) it corresponds to.");
            int min, max;
            while (true)
            {
                try
                {
                    Console.Write("Min: ");
                    min = int.Parse(Console.ReadLine());
                    Console.Write("Max: ");
                    max = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Your input is not a number :( \nTry again...");
                }
            }
            foreach(Vegetable vegetable in salad)
            {
                if (vegetable.calorie > min && vegetable.calorie < max)
                {
                    Console.WriteLine($"{vegetable.name}: {vegetable.calorie}");
                }
            }
        }
    }
}

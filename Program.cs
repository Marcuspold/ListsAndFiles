using System;
using System.Collections.Generic;

namespace ListsAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            List<string> fruit = new List<string>();

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a fruit:");
                fruit.Add(Console.ReadLine());
            }
            foreach(string fruititem in fruit)
            {
                Console.WriteLine($"Fruit on the list: {fruititem}");
            }
            fruit.Add("pineapple");
            foreach (string fruititem in fruit)
            {
                Console.WriteLine($"Fruit on the list: {fruititem}");
            }
            int indexOfPineapple = fruit.IndexOf("pineapple");

            Console.WriteLine($"Pineapple is on index {indexOfPineapple}");

            fruit[indexOfPineapple] = "Orange";
            foreach (string fruititem in fruit)
            {
                Console.WriteLine($"Fruit on Updated list: {fruititem}");
            }


            fruit.RemoveAt(fruit.Count-1);

            foreach (string fruititem in fruit)
            {
                Console.WriteLine($"Trimed Fruit list: {fruititem}");
            }
        }
    }
}

# ListsAndFiles

## WorkingWithFiles
``` 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            string filePath = @"C:\Users\opilane\Data\test.txt";
            List<string> dataFromFile = File.ReadAllLines(filePath).ToList();

            foreach(string line in dataFromFile)
            {
                Console.WriteLine($"Data from file: {line}");
            }
            dataFromFile.Add("Watermelon");
            File.WriteAllLines(filePath, dataFromFile);

        }
    }
}

```

## WishList
``` 
using System;
using System.Collections.Generic;
using System.IO;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            List<string> Wish = new List<string>();

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter your wishes: ");
                Wish.Add(Console.ReadLine());
            }
            string FilePath = @"C:\Users\opilane\Data\WishList.txt";
            File.WriteAllLines(FilePath, Wish);

        }
    }
}

```

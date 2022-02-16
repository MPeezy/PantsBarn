using System;
using System.Collections.Generic;

namespace PantsBarn
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pants> pants = new List<Pants>();
            pants.Add(new Pants("Jeans", new List<int>() { 4, 6, 10, 14, 16, 18 }));
            pants.Add(new Pants("Cords", new List<int>() { 3, 7, 9, 11, 13 }));
            pants.Add(new Pants("Sweatpants", new List<int>() { 6, 8, 10, 14, 16 }));
            pants.Add(new Pants("Chinos", new List<int>() { 2, 8, 10, 14, 18 }));

            Console.WriteLine("Welcome to Tiia's Big Barn of Pants!");

            bool goAgain = true;
            while (goAgain)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add pants");
                Console.WriteLine("2. Check availibility");
                Console.WriteLine("3. Delete pants");
                Console.WriteLine("4. See all the pants");

                int choice = int.Parse(Console.ReadLine());

                if(choice == 1)
                {
                    Console.WriteLine("Please enter the style to add:");
                    string style = Console.ReadLine();
                    Console.WriteLine("Please enter the number of sizes available:");
                    int numberOfSizes = int.Parse(Console.ReadLine());
                    List<int> sizes = new List<int>();
                    for(int i = 0; i < numberOfSizes; i++)
                    {
                        Console.Write("Size " + (i + 1) + ":");
                        sizes.Add(int.Parse(Console.ReadLine()));
                    }
                    pants.Add(new Pants(style, sizes));
                    Console.WriteLine("Thank you - " + style + " have been added in " + numberOfSizes + " sizes!");
                }
                if (choice == 2)
                {
                    Console.WriteLine("Which style are you looking for?");
                    string style = Console.ReadLine();
                    Console.WriteLine("And in what size?");
                    int size = int.Parse(Console.ReadLine());
                    bool available = false;
                    foreach(Pants pant in pants)
                    {
                        if(pant.GetStyle() == style)
                        {
                            available = pant.IsAvailable(size);
                        }
                    }
                    if (available)
                    {
                        Console.WriteLine("We have those in stock!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, those are not in stock");
                    }

                }
                if (choice == 3)
                {
                    Console.WriteLine("Please enter the style to delete:");
                    string style = Console.ReadLine();
                    for(int i = 0; i < pants.Count; i++)
					{
                        if(pants[i].GetStyle() == style)
						{
                            pants.Remove(pants[i]);
						}
					}
                }
                if (choice == 4)
                {
                    foreach(Pants pant in pants)
					{
						Console.WriteLine(pant.ToString());
					}
                }

                Console.WriteLine("Would you like to continue? y/n");
                string keepGoing = Console.ReadLine();
                if(keepGoing == "n")
                {
                    goAgain = false;
                    Console.WriteLine("Thanks for visiting!");
                }
            }
        }
    }
}

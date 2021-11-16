using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace MyShoppingListFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\User\sample\ShoppingList";
            string fileName = @"\\myShoppingList.txt";


            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add an item? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Add an item to your shopping list:");
                    string useritem = Console.ReadLine();
                    myShoppingList.Add(useritem);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Take care!");
                }

            }
            Console.Clear();
            foreach (string item in myShoppingList)
            {
                Console.WriteLine($"Your item: {item}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myShoppingList);
        }
    }
}

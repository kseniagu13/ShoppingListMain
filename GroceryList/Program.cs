using System;
using System.Collections.Generic;

namespace GroceryList
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goToShopping = false;
            List<string> ShoppingLists = new List<string>();
            Console.WriteLine("Enter your list of supplies separated by comma: ");
            string userList = Console.ReadLine();
            string [] shoppingList = userList.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ShoppingLists.AddRange(shoppingList); //lisasime tooted meie shopping listi
            Console.Clear();
            Console.WriteLine("Your shopping list: ");
            for (int i = 0; i < ShoppingLists.Count; i++)
            { 
                Console.WriteLine($"Item {i + 1}: {ShoppingLists[i]}");

            }
            

            while (!goToShopping)
            {
                Console.WriteLine("Do you want to add/remove something from your shopping list? or shopping?");
                string userAnswer = Console.ReadLine();
                if (userAnswer.ToLower() == "add") // ADD ITEM
                {
                    Add(userAnswer, ShoppingLists);
                    
                }
                else if (userAnswer.ToLower() == "remove") // Remove item
                {
                    Remove(userAnswer, ShoppingLists);
                   
                }

                else if (userAnswer.ToLower() == "shopping")
                {
                    Console.WriteLine("Enjoy your shopping! Your shopping list:");
                    for (int i = 0; i < ShoppingLists.Count; i++)
                    {
                        Console.WriteLine($"Item {i + 1}: {ShoppingLists[i]}");

                    }
                    
                    goToShopping = true;

                }
                else
                {
                    Console.WriteLine("Choose: Add, remove, or shopping?");
                    continue;
                }


            }



            Console.ReadLine();
        }

        public static void Add ( string itemToAdd, List<string> ShoppingList)
        {
            
            Console.WriteLine("What item do you want to add?");
            itemToAdd = Console.ReadLine();
            Console.Clear();
            string[] userAnswerAdd = itemToAdd.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            ShoppingList.AddRange(userAnswerAdd);
            Console.WriteLine("Your shopping list:");
            for (int i = 0; i < ShoppingList.Count; i++)
            {
                Console.WriteLine($"Item {i + 1}: {ShoppingList[i]}");

            }
        }

        public static void Remove (string itemToRemove, List<string> GroceryList)
        {
            
            Console.WriteLine("What item do you want to remove?");
            itemToRemove = Console.ReadLine();
            Console.Clear();
            string[] userAnswerRemove = itemToRemove.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int sizeOfArray = userAnswerRemove.Length;
            Console.WriteLine(sizeOfArray); 

            GroceryList.Remove(itemToRemove);
            Console.WriteLine("Your shopping list:");
            for (int i = 0; i < GroceryList.Count; i++)
            {
                Console.WriteLine($"Item {i + 1}: {GroceryList[i]}");

            }
        }

           
               

            

        
    }
}

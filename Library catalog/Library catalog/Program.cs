using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Library_catalog
{
    class Program
    {
        public static void Main(string[] args)
        {
            CardCatalog cc = new CardCatalog();
            DisplayMenu(cc);
        }

        public static void DisplayMenu(CardCatalog cc)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu(cc);
                Console.WriteLine();
            }
        }

        public static bool MainMenu(CardCatalog cc)
        {

            Console.WriteLine("1) Add a book.");
            Console.WriteLine("2) Get book information by all ISBN.");
            Console.WriteLine("3) Search book by any keywords.");
            Console.WriteLine("4) List all books.");
            Console.WriteLine("5) Exit.");
            Console.Write("> ");
            string result = Console.ReadLine();

            if (result == "1")
            {
                cc.AddABook();
                return true;
            }
            else if (result == "2")
            {
                cc.search_by_ISBN();
                return true;
            }
            else if (result == "3")
            {
                cc.search_by_keywords();
                return true;
            }
            else if (result == "4")
            {
                cc.ListAllBooks();
                return true;
            }
            else if (result == "5")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

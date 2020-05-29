using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text.RegularExpressions;

namespace Library_catalog
{
    public class CardCatalog
    {
        public CardCatalog(){
            bookList = new List<Book>();
        }
        private List<Book> bookList { get; set; }
        
        public void AddABook()
        {
            Console.WriteLine("Add a book");

            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            
            Console.Write("Enter author's name: ");
            string author = Console.ReadLine();

            Console.Write("Enter the annotation: ");
            string genre = Console.ReadLine();

            long isbn;
            string isbnInput;
            do
            {
                do
                {
                    Console.Write("Enter the 13 digit ISBN: ");
                    isbnInput = Console.ReadLine();
                } while (isbnInput.Length!= 13);
            } while (!long.TryParse(isbnInput, out isbn));
            
            Console.Write("Enter the date: ");
            string date = Console.ReadLine();

            bookList.Add(new Book(title, author, genre, isbn, date));
            Console.WriteLine("this book added!");
        }

        public void ListAllBooks()
        {
            foreach (Book book in bookList)
            {
                Console.WriteLine("Title: {0}, Author: {1}, Annotation: {2}, ISBN: {3}, Date: {4}",
                    book.Title, book.Author, book.Annotation, book.ISBN , book.Date);
            }
        }
        
        public void search_by_ISBN()
        {
            
            foreach (Book book in bookList)
            {
                long isbn;
                string isbnInput;
                do
                {
                    do
                    {
                        Console.Write("Enter the 13 digit ISBN: ");
                        isbnInput = Console.ReadLine();
                    } while (isbnInput.Length!= 13);
                } while (!long.TryParse(isbnInput, out isbn));

                if (isbn == book.ISBN)
                {
                    Console.WriteLine("Title: {0}, Author: {1}, Annotation: {2}, ISBN: {3}, Date: {4}",
                        book.Title, book.Author, book.Annotation, book.ISBN , book.Date);
                }
            }
        }
        public void search_by_keywords()
        {
            
            foreach (Book book in bookList)
            {
                Console.Write("Enter any keywords: ");
                string keywords = Console.ReadLine();
                
                string[] keywords_words = keywords.Split(new Char[] { ' ',',','.','!','?' });

                string[] book_words = book.Annotation.Split(new Char[] { ' ',',','.','!','?' });

                
                int temp_sum = 0;
                int gggg = keywords_words.Length;
                for (int i = 0; i < keywords_words.Length; i++)
                {
                    for (int j = 0; j < book_words.Length; j++)
                    {
                        if (keywords_words[i] == book_words[j])
                        {
                            temp_sum++;
                        }
                    }
                }

                if (temp_sum != 0)
                {
                    Console.WriteLine("Title: {0}, Author: {1}, ISBN: {2}, Date: {3}",
                        book.Title, book.Author, book.ISBN , book.Date);
                }
            }
            
        }
        
        
    }
}
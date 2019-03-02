using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;


namespace Challenge_24
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            string password;
            bool correct= false;
            string usernameguess;
            string passwordguess;

            string fileName = @"C:\Users\Charlie\Documents\C#\OCR Code Challenges\24\file.docx";
            var doc = DocX.Create(fileName);
            doc.InsertParagraph("Hello World");
            doc.Save();


            Console.Write("Please enter a username: ");
            username = Console.ReadLine();

            Console.Write("Please enter a password: ");
            password = Console.ReadLine();

            while (correct == false)
            {
                Console.Write("What is the username: ");
                usernameguess = Console.ReadLine();

                Console.Write("What is the password: ");
                passwordguess = Console.ReadLine();

                if (usernameguess == username && passwordguess == password)
                {
                    Process.Start("WINWORD.EXE", fileName);
                    correct = true;
                }
                else
                {
                    Console.WriteLine("Wrong username or password, try again");
                    correct = false;
                }
            }
            Console.ReadKey();
        }
    }
}

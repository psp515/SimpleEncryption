using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace EncryptionApp.Helpers
{
    public class Helpers
    {
        public static int Randomize(int min,int max) 
        {
            Random a = new Random();
            return a.Next(min, max);
        }
        public static void TextBreak() => Console.WriteLine("-------------------------------------------------------------------");
        public static string GoodBye()
        {
            int a = Randomize(1, 6);
            switch(a)
            {
                case 1:
                    return "Have a nice day!";
                case 2:
                    return "Enjoy the day!";
                case 3:
                    return "Enjoy the Encryption!";
                case 4:
                    return "See ya!";
                case 5:
                    return "Good day to You Sir!";
                case 6:
                    return "Till the next time!";
                default:
                    return "Error";
            }
        }
        public static int GetUserChoice(Action writeMenu, int choiceMin, int choiceMax, string menuName)
        {
            writeMenu();
            int choice = GetIntChoice();
            if (choice < choiceMin || choice > choiceMax || choice == -1)
            {
                Console.Clear();
                Console.WriteLine(" Moving to {0} menu. Please choose correct option...", menuName);
                Thread.Sleep(2000);
                Console.Clear();
                return -1;
            }

            return choice;
        }
        private static int GetIntChoice()
        {
            string a = Console.ReadLine();
            if (Regex.IsMatch(a, @"^\d+$"))
            {
                return Int32.Parse(a);
            }
            return -1;
        }
        public static string GetString(string description)
        {
            Console.Clear();
            Console.WriteLine("\t\t\tTaking Input");
            TextBreak();
            Console.WriteLine(description);
            return Console.ReadLine();
        }   
        public static void Error()
        {
            Console.Clear();
            Console.WriteLine("An error has occurred.");
            Console.WriteLine("Moving to main menu...");
            Thread.Sleep(2000);
            Console.Clear();
            Program.Starting();
        }
        public static void WrongOption()
        {
            Console.Clear();
            Console.WriteLine("Wrong option. Please select correct option...");
            Thread.Sleep(2000);
        }
        public static string CreateEncodeOutput(string encodedMessage, string privateKey, string publicKey) => string.Format("Your private decode key: \n{0}\nYour public decode key: \n{1}\nYour Encoded Message: \n{2}", privateKey, publicKey, encodedMessage);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace SimpleEncryption
{
    public class Helpers
    {
        public static string DirectoryPath { get; set; }
        public static bool isFirstTime { get; set; } = true;

        public static int Randomize(int min, int max)
        {
            Random a = new Random();
            return a.Next(min, max);
        }
        public static void TextBreak() => Console.WriteLine("-------------------------------------------------------------------");
        public static int GetUserChoice(Action writeMenu, int choiceMin, int choiceMax, string menuName)
        {
            writeMenu();
            int choice = GetIntChoice();
            if (choice < choiceMin || choice > choiceMax || choice == -1)
            {
                Console.Clear();
                Console.WriteLine("Moving to {0} menu. Please choose correct option...", menuName);
                Thread.Sleep(2000);
                Console.Clear();
                return -1;
            }

            return choice;
        }
        public static void Error()
        {
            Console.Clear();
            Console.WriteLine("An error has occurred.");
            Console.WriteLine("Moving to main menu...");
            Thread.Sleep(2000);
            Console.Clear();
            Program.Main();
        }
        public static string GetString(string description)
        {
            Console.Clear();
            Console.WriteLine("\t\t\tTaking Input");
            TextBreak();
            Console.WriteLine(description);
            TextBreak();
            return Console.ReadLine();
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

        internal static void SpecificUnauthorizedException()
        {
            Console.Clear();
            Console.WriteLine("If u see this message you shoud run this app as administrator or change the folder with app.");
            Thread.Sleep(6000);
            Environment.Exit(0);
        }
    }
}

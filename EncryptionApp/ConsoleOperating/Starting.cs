using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using EncryptionApp.Ciphers.C_Classes;
using EncryptionApp.ConsoleOperating;
using EncryptionApp.Helpers;
using static System.Net.Mime.MediaTypeNames;

namespace EncryptionApp.ConsoleVisualAspects
{
    public class Starting
    {
        public static void StartingProcess()
        {
            Console.Title = "EncryptionApp";
            Welcome();
            ReadInput();
        }

        private static void ReadInput()
        {
            Start:
            Console.WriteLine("Press: \n" +
               "[1] - Encode message,\n" +
               "[2] - Decode message,\n" +
               "[3] - Leave app.\n(press enter to Apply decision)");
            string Input = Console.ReadLine().Trim();
            if(Input=="1")
            {
               string str = GetMessage();
               Encode e = new Encode(str);
            }
            else if(Input=="2")
            {
                string Key = GetCode();
                string EncodedMessage = GetMessage();
                Decode d = new Decode(EncodedMessage,Key);
            }
            else if(Input=="3")
            {
                Thread.Sleep(TimeSpan.FromSeconds(0.5));
                Console.WriteLine("Thanks for spending time with my app.");
                Console.WriteLine(Helpers.Helpers.GoodBye());
                Thread.Sleep(TimeSpan.FromSeconds(2));
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please choose the correct option.");
                goto Start;
            }

        }

        public static void Welcome()
        {
            Console.WriteLine("Welcome to EncryptionApp!!");
        }
        public static string GetMessage()
        {
            Console.WriteLine("Write the message here: (press enter to end writing)");
            return Console.ReadLine();
        }
        public static string GetCode()
        {
            Console.WriteLine("Write the decode code here: (press enter to end writing)");
            return Console.ReadLine();
        }
    }
}

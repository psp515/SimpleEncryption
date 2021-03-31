using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using EncryptionApp.Ciphers.C_Classes;
using EncryptionApp.ConsoleOperating;
using EncryptionApp.Helpers;

namespace EncryptionApp.ConsoleVisualAspects
{
    public class Starting
    {
        public static void StartingProcess()
        {
            Console.Title = "EncryptionApp";
            Console.WriteLine("\t\t\tWelcome to EncryptionApp!!");
            Action menu = delegate ()
            {
                Helpers.Helpers.TextBreak();
                Console.WriteLine("List of possible options: \n" +
               "[1] - Encode message\n" +
               "[2] - Decode message\n" +
               "[3] - Leave app\n(press enter to Apply decision)");
                Helpers.Helpers.TextBreak();
            };
            int choice = Helpers.Helpers.GetUserChoice(menu, 1, 3, "Main");
            FindOption(choice);
        }
        private static void FindOption(int choice)
        {
            
            if(choice == 1)
            {
                string message = GetMessage();
                Encode e = new Encode(message);
            }
            else if(choice == 2)
            {
                string key = Helpers.Helpers.GetString("Write the decode code here: (press enter to end writing)");
                string encodedMessage = GetMessage();
                Console.WriteLine("---------------------------------------------------------------");
                Decode d = new Decode(encodedMessage,key);
            }
            else if(choice == 3)
            {
                Ending e = new Ending();
                e.QuitApp();
            }
            else if (choice == -1)
            {
                StartingProcess();
            }
            else
                Helpers.Helpers.Error();
            
        }
        private static string GetMessage()
        {
            start:
            Console.Clear();
            Action menu = delegate ()
            {
                Console.WriteLine("\t\t\tEncode Options");
                Helpers.Helpers.TextBreak();
                Console.WriteLine("List of possible options: \n" +
               "[1] - Write message in console\n" +
               "[2] - Attach txt file (work in progress)\n(press enter to Apply decision)");
                Helpers.Helpers.TextBreak();
            };
            int choice = Helpers.Helpers.GetUserChoice(menu, 1, 3, "Message");

            if (choice == 1)
            {
                return Helpers.Helpers.GetString("Please, write message now:");
            }
            else if (choice == 2)
            {
                return Helpers.Helpers.GetString("Please, write message now:");
            }
            else if (choice == -1)
            {
                goto start;
            }
            else
            {
                Helpers.Helpers.Error();
                return null;
            }
        }    
    }
}

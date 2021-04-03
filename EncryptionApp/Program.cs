﻿using EncryptionApp.ConsoleOperating;
using EncryptionApp.ConsoleVisualAspects;
using EncryptionApp.FilesManagement;
using EncryptionApp.Helpers;
using System;
using System.Threading;

namespace EncryptionApp
{
    class Program
    {
        public static bool isFirst { get; set; }
        static void Main() 
        {
            Console.Title = "EncryptionApp";
            Console.WriteLine("\t\t\tWelcome to EncryptionApp!!");
            isFirst = true;
            Starting();
        }

        public static void Starting()
        {
            if (!isFirst)
                Console.WriteLine("\t\t\tMain Menu");
            isFirst = false;
            Action menu = delegate ()
            {
                Helpers.Helpers.TextBreak();
                Console.WriteLine("List of possible options: \n[1] - Encode message\n[2] - Decode message\n[3] - Create Directory\n[4] - Leave app\n(press enter to Apply decision)");
                Helpers.Helpers.TextBreak();
            };
            
            FindOption(Helpers.Helpers.GetUserChoice(menu, 1, 3, "Main"));
        }

        private static void FindOption(int choice)
        {

            if (choice == 1)
            {
                EncodeStarting encodeStarting = new EncodeStarting();
                encodeStarting.GetEncodedMessage();
            }
            else if (choice == 2)
            {
                Starting s = new Starting();
                s.StartingDecode();
            }
            else if (choice == 3)
            {
                DirectoryManagement directoryManagement = new DirectoryManagement();
                directoryManagement.CreateMainDirectories();
                Starting();
            }
            else if (choice == 4)
            {
                Ending e = new Ending();
                e.QuitApp();
            }
            else if (choice == -1)
            {
                Starting();
            }
            else
                Helpers.Helpers.Error();

        }
    }
}

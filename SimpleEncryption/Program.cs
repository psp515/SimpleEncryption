using SimpleEncryption.ConsoleControl;
using SimpleEncryption.ConsoleControl.Decryption;
using SimpleEncryption.ConsoleControl.Encryption;
using SimpleEncryption.Files;
using System;
using System.IO;

namespace SimpleEncryption
{
    class Program
    {
        public static void Main()
        {
            SetInfo();
            
            Action menu = delegate ()
            {
                Helpers.TextBreak();
                Console.WriteLine("List of possible options: \n[1] - Encode message\n[2] - Decode message\n[3] - Leave app\n(press enter to Apply decision)");
                Helpers.TextBreak();
            };

            InterpretOption(Helpers.GetUserChoice(menu, 1, 3, "Main"));
        }

        private static void InterpretOption(int choice)
        {
            if (choice == 1)
            {
                GetEncodeInfo getInfo = new GetEncodeInfo();
                getInfo.GetMessage();
            }
            else if (choice == 2)
            {
                GetDecodeInfo getInfo = new GetDecodeInfo();
                getInfo.GetInfo();
            }
            else if (choice == 3)
            {
                End end = new End();
                end.EndRandom();
            }
            else if (choice == -1)
            {
                Main();
            }
            else
                Helpers.Error();
        }

        private static void SetInfo()
        {
            Console.Clear();

            Helpers.DirectoryPath = Directory.GetCurrentDirectory();
            Console.Title = "EncryptionApp";

            if (Helpers.isFirstTime)
                Console.WriteLine("\t\t\tWelcome to EncryptionApp!!");
            else
                Console.WriteLine("\t\t\tMain Menu");
            Helpers.isFirstTime = false;

            DirectioriesManagement directioriesManagement = new DirectioriesManagement();
            directioriesManagement.CreateMainDirectories(false);
        }
    }
}

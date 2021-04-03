using EncryptionApp.ConsoleVisualAspects;
using EncryptionApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using EncryptionApp.FilesManagement;

namespace EncryptionApp.ConsoleOperating
{
    public class Ending
    {
        protected string DecodedMessage { get; set; }
        protected string EncodedMessage { get; set; }
        protected string PublicKey { get; set; }
        protected string PrivateKey { get; set; }

        public Ending()
        {
            
        }
        public Ending(string decodedMessage)
        {
            DecodedMessage = decodedMessage;
            EndDecode();
        }
        public Ending(string encodedMessage, string privateKey, string publicKey)
        {
            EncodedMessage = encodedMessage;
            PrivateKey = privateKey;
            PublicKey = publicKey;
            EndEncode();
        }

        private void EndDecode()
        {
            Console.WriteLine("Your decoded message:");
            Console.WriteLine(DecodedMessage);

            EndingProcess();
        }
        public void EndEncode()
        {
            Console.Clear();
            Console.WriteLine("\t\t\tMessage Encrypted");
            Helpers.Helpers.TextBreak();
            FilesManagement.FilesManagement filesManagement = new FilesManagement.FilesManagement(EncodedMessage, PrivateKey,PublicKey);
            filesManagement.CreateFile();
            Console.WriteLine(Helpers.Helpers.CreateEncodeOutput(EncodedMessage, PrivateKey, PublicKey));
            EndingProcess();
        }

        private void EndingProcess()
        {
            Action writeMenu = delegate ()
            {
                Helpers.Helpers.TextBreak();
                Console.WriteLine("Do you want to leave app?");
                Console.WriteLine("[1] - Main Menu\n[2] - Quit\n(enter to Apply decision)");
            };
            int a = Helpers.Helpers.GetUserChoice(writeMenu,1,2,"Ending Menu");
            if (a == 1)
            {
                Console.Clear();
                Program.Starting();
            }
            else if (a == 2)
                QuitApp();
            else
                EndEncode();
        }

        public void QuitApp()
        {
            Console.Clear();
            Thread.Sleep(TimeSpan.FromSeconds(0.5));
            Console.WriteLine("Thanks for spending time with my app.");
            Console.WriteLine(Helpers.Helpers.GoodBye());
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Environment.Exit(0);
        }

    }
}

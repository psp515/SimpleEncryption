using EncryptionApp.ConsoleVisualAspects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
            Console.WriteLine("Sorry something went wrong :(");
            Starting.StartingProcess();
        }
        public Ending(string decodedMessage)
        {
            DecodedMessage = decodedMessage;
            EndDecode();
        }

        private void EndDecode()
        {
            Console.WriteLine("Your decoded message:");
            Console.WriteLine(DecodedMessage);

            EndingProcess();
        }

        public Ending(string encodedMessage, string privateKey, string publicKey)
        {
            EncodedMessage = encodedMessage;
            PrivateKey = privateKey;
            PublicKey = publicKey;
            EndEncode();
        }

        public void EndEncode()
        {
            Console.WriteLine("Your private decode key:");
            Console.WriteLine(PrivateKey);
            Console.WriteLine("Your public decode key:");
            Console.WriteLine(PublicKey);
            Console.WriteLine("Your Encoded Message");
            Console.WriteLine(EncodedMessage);

            EndingProcess();
        }

        private void EndingProcess()
        {
            Start:
            Console.WriteLine("Do you want to leave app?");
            Console.WriteLine("[1] - Quit \n[2] - Main Menu\n(enter to Apply decision)");
            string a=Console.ReadLine();
            if (a.Trim() == "1")
            {
                Thread.Sleep(TimeSpan.FromSeconds(0.5));
                Console.WriteLine("Thanks for spending time with my app.");
                Console.WriteLine(Helpers.Helpers.GoodBye());
                Thread.Sleep(TimeSpan.FromSeconds(2));
                Environment.Exit(0);
            }
            else if (a.Trim() == "2")
                Starting.StartingProcess();
            else
            {
                Console.WriteLine("Please choose the correct option.");
                goto Start;
            }
            
        }

    }
}

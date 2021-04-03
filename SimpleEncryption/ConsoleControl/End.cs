using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleEncryption.ConsoleControl
{
    public class End
    {
        string Message { get; set; }
        string PublicKey { get; set; }
        string PrivateKey { get; set; }
        public End()
        {

        }
        public End(string decodedMessage)
        {
            Message = decodedMessage;
        }
        public End(string publicKey, string privateKey, string message)
        {
            Message = message;
            PublicKey = publicKey;
            PrivateKey = privateKey;
        }

        public void EndEncode()
        {
            Console.Clear();
            Console.WriteLine("\t\t\tEncoded Menu");
            Console.WriteLine(string.Format("Your private decode key: \n{0}\nYour public decode key: \n{1}\nYour encoded Message: \n{2}\n(files created at{3})", PrivateKey, PublicKey, Message,Helpers.DirectoryPath));
           
            EndingProcess();
        }
        public void EndDecode()
        {
            Console.Clear();
            Console.WriteLine("\t\t\tDecoded Menu");
            Console.WriteLine(string.Format("Your decoded Message: \n{0}", Message));

            EndingProcess();
        }
        public void EndRandom()
        {
            throw new NotImplementedException();
        }

        private void EndingProcess()
        {
            Action writeMenu = delegate ()
            {
                Helpers.TextBreak();
                Console.WriteLine("Do you want to leave app?");
                Console.WriteLine("[1] - Main Menu\n[2] - Quit\n(enter to Apply decision)");
                Helpers.TextBreak();
            };

            int a = Helpers.GetUserChoice(writeMenu, 1, 2, "Ending Menu");

            if (a == 1)
            {
                Console.Clear();
                Program.Main();
            }
            else if (a == 2)
                EndRandom();
            else
                EndEncode();
        }
    }
}

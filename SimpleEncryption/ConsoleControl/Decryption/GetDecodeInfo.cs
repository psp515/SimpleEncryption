using SimpleEncryption.Files;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SimpleEncryption.ConsoleControl.Decryption
{
    public class GetDecodeInfo
    {
        public string Key { get; set; }
        public string EncodedMessage { get; set; }
        public void GetInfo()
        {
            Console.Clear();
            Console.WriteLine("\t\t\tAttachment Menu");
            Key = Helpers.GetString("Please provide the key:");
            Helpers.TextBreak();
            GetStringMessage();
        }

        public void GetStringMessage()
        {
            Console.Clear();
            Console.WriteLine("\t\t\tAttachment Menu");
            Action menu = delegate ()
            {
                Helpers.TextBreak();
                Console.WriteLine("List of possible options: \n[1] - Write message in console\n[2] - Write file name (write only file name, file should be in {0}/ToDecode)\n[3] - Restart Decoding\n(press enter to Apply decision)");
                Helpers.TextBreak();
            };
            FindOption(Helpers.GetUserChoice(menu, 1, 3, "Attachment"));
        }

        private void FindOption(int choice)
        {
            if (choice == 1)
            {
                EncodedMessage = Helpers.GetString("Please provide a message:");
                EncodedMessage.Trim();
                Helpers.TextBreak();
                StartDecode();
            }
            else if (choice == 2)
            {
                string fileName = Helpers.GetString(string.Format("Please provide the file name:\n" + @"(write only file name, file should be in {0}\ToDecode)", Helpers.DirectoryPath));
                Helpers.TextBreak();
                FileManagement fileManagement = new FileManagement();
                string message = fileManagement.ReadFileToDecode(fileName.Trim());

                if (message == null)
                    FileNotFound();
                EncodedMessage = message.Trim();
                StartDecode();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Restarting...");
                Thread.Sleep(500);
                GetInfo();
            }
            else if (choice == -1)
            {
                GetStringMessage();
            }
            else
            {
                Helpers.Error();
            }
        }

        private void FileNotFound()
        {
            Console.Clear();
            Console.WriteLine(@"Sorry app coudn't find this file or file has no content. Please check if file is in {0}\ToDecode or has anything to Encode.");
            Thread.Sleep(2500);
            GetStringMessage();
        }

        private void StartDecode()
        {
            Decode decode = new Decode(EncodedMessage,Key);
        }
    }
}

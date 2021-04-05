using SimpleEncryption.Files;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SimpleEncryption.ConsoleControl.Encryption
{
    public class GetEncodeInfo
    {
        public GetEncodeInfo(){ }

        public void GetMessage()
        {
            Console.Clear();
            Console.WriteLine("\t\t\tAttachment Menu");
            Action menu = delegate ()
            {
                Helpers.TextBreak();
                Console.WriteLine("List of possible options: \n[1] - Write message in console\n[2] - Write file name (file should be at AppFolder/ToEncode)\n(press enter to Apply decision)");
                Helpers.TextBreak();
            };

            FindOption(Helpers.GetUserChoice(menu, 1, 2, "Attachment"));  
        }

        private void FindOption(int choice)
        {
            Helpers.TextBreak();
            if (choice == 1)
            {
                string message = Helpers.GetString("Please provide a message:");
                Helpers.TextBreak();
                StartEncode(message);
            }
            else if (choice == 2)
            {
                string fileName = Helpers.GetString(string.Format("Please provide the file name:\n" + @"(write only file name, file should be in {0}\ToEncode)", Helpers.DirectoryPath));
                Helpers.TextBreak();
                FileManagement fileManagement = new FileManagement();
                string message = fileManagement.ReadFileToEncode(fileName.Trim());

                if (message == null)
                    FileNotFound();

                StartEncode(message);
            }
            else if (choice == -1)
            {
                 GetMessage();
            }
            else
            {
                Helpers.Error();
            }
        }

        private void FileNotFound()
        {
            Console.Clear();
            Console.WriteLine(@"Sorry app coudn't find this file or file has no content. Please check if file is in {0}\ToEncode or has anything to Encode.");
            Thread.Sleep(2500);
            GetMessage();
        }

        private void StartEncode(string message)
        {
            Encode e = new Encode(message.Trim());
            e.EncoidingMessage();
        }
    }
}

using EncryptionApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.ConsoleOperating
{
    public class EncodeStarting
    {
        public void GetEncodedMessage()
        {
            Console.Clear();
            Console.WriteLine("Attachment Menu");
            Action menu = delegate ()
            {
                Helpers.Helpers.TextBreak();
                Console.WriteLine("List of possible options: \n[1] - Write message in console\n[2] - Write file name\n(press enter to Apply decision)");
                Helpers.Helpers.TextBreak();
            };
            FindOption(Helpers.Helpers.GetUserChoice(menu,1,2,"Attachment"));
        }

        private void FindOption(int choice)
        {
            if (choice == 1)
            {
                StartEncode(Helpers.Helpers.GetString("Please provide a message:"));
            }
            else if (choice == 2)
            {
                string fileName = Helpers.Helpers.GetString(@"Please provide the file name: (wiret only file name also file should be in C:\EncryptionApp\Encode\)");
                FilesManagement.FilesManagement filesManagement = new FilesManagement.FilesManagement();
                string encodedMessage = filesManagement.ReadFile(fileName.Trim());
                StartEncode(encodedMessage.Trim());
            }
            else if (choice == -1)
            {
                GetEncodedMessage();
            }
            else
                Helpers.Helpers.Error();
        }

        private void StartEncode(string encodedMessage)
        {
            Encode e = new Encode(encodedMessage);
            e.Process();
        }
    }
}
 
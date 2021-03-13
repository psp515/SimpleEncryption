using EncryptionApp.ConsoleOperating.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Helpers
{
    public class Encode : IDE
    {
        public string Message { get; set; }
        public string FullCode { get; set; }

        public void StartProcess()
        {
            Console.WriteLine("Let's start Encoding!");
            GetMessage();
            StartEncode();
        }

        private void StartEncode()
        {
            throw new NotImplementedException();
        }

        public void GetMessage()
        {
            Console.WriteLine("Please write the message:  (press enter to end writing message)");
            Message = Console.ReadLine(); 
        }
    }
}

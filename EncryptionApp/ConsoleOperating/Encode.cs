using EncryptionApp.Ciphers;
using EncryptionApp.Ciphers.C_Classes;
using EncryptionApp.ConsoleOperating.Interface;
using EncryptionApp.ConsoleVisualAspects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Helpers
{
    public class Encode : IDE
    {
        public int coutSSI { get; set; } = 0;
        public string Message { get; set; } 
        public string FullCode { get; set; }
        public string EncodedMessage { get; set; }

        public Encode()
        {
            
        }

        public Encode(string str)
        {
           Message = str;
           Process();
            Console.WriteLine("end");
            Starting.StartingProcess();
         
        }

        public void Process()
        {
            InitializeCiphers Ic = new InitializeCiphers();
            int S = Helpers.Randomize(0, 1);
            int SI = Helpers.Randomize(0, 1);
            Console.WriteLine(Ic.ListSI);
            Console.WriteLine(Ic.ListS);
            //Uwaga fence cipher musi mieć mniejsze n niż długośc wiadomości.
            CipherS Cipher_1 = Ic.ListS[S];
            CipherSI Cipher_2 = Ic.ListSI[SI];

            //1st Encode
            EncodedMessage = Cipher_1.Encode(Message);
            FullCode += Cipher_1.Code;

            //2nd Encode
            EncodedMessage = Cipher_2.Encode(EncodedMessage,(Cipher_2.Code.Contains("C")? Helpers.Randomize(5, 13) : Helpers.Randomize(4, 8)));
            FullCode += Cipher_2.GetCode();

            Console.WriteLine(EncodedMessage);
            Console.WriteLine(FullCode);
        }

       
    }
}

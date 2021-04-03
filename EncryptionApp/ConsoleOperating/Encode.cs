using EncryptionApp.Ciphers;
using EncryptionApp.Ciphers.C_Classes;
using EncryptionApp.ConsoleOperating;
using EncryptionApp.ConsoleOperating.Interface;
using EncryptionApp.ConsoleVisualAspects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Helpers
{
    public class Encode : IDE
    {
        public string Message { get; set; } 
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
        public string EncodedMessage { get; set; }

        public Encode()
        {
            Console.WriteLine("Something went wrong...");
        }
        public Encode(string str)
        {
           Message = str;
        }

        public void Process()
        {
            Console.WriteLine(Message);
            Console.ReadLine();
            InitializeCiphers Ic = new InitializeCiphers();

            int S = Helpers.Randomize(0, 7);
            int SI = Helpers.Randomize(0, 5);
            int SI2 = Helpers.Randomize(0, 5);

            CipherStrModel Cipher_1 = Ic.ListS[S];
            CipherStrIntModel Cipher_2 = Ic.ListSI[SI];
            CipherStrIntModel Cipher_3 = Ic.ListSI[SI>2?SI-1:SI+1];

            //1st Encode
            EncodedMessage = Cipher_1.Encode(Message);
            Console.WriteLine(EncodedMessage);
            //2nd Encode
            EncodedMessage = Cipher_2.Encode(EncodedMessage, Helpers.Randomize(6, 17));
            Console.WriteLine(EncodedMessage);
            //3rd Encode
            EncodedMessage = Cipher_3.Encode(EncodedMessage, Helpers.Randomize(6, 17));
            Console.WriteLine(EncodedMessage);
            //Create Keys
            PrivateKey = CreatePrivateKey(Cipher_1, Cipher_2, Cipher_3);
            PublicKey = CreatePublicKey(PrivateKey, Ic.ListS[(int)(S/2)]);

            Ending e = new Ending(EncodedMessage,PrivateKey,PublicKey);
        }
        public string CreatePrivateKey(CipherStrModel s1, CipherStrIntModel s2, CipherStrIntModel s3) =>string.Format("{0}-{1}-{2}",s1.GetCode(),s2.GetCode(), s3.GetCode());
        public string CreatePublicKey(string privateKey, CipherStrModel CSI) 
        {
            privateKey = CSI.Encode(privateKey);
            return CSI.GetCode()+"-"+privateKey;
        }

    }
}

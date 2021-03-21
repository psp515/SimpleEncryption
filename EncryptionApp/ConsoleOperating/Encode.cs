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
        public int coutSSI { get; set; } = 0;
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
           Process();
        }

        public void Process()
        {
            InitializeCiphers Ic = new InitializeCiphers();
            int S = Helpers.Randomize(0, 19);
            int SI = Helpers.Randomize(0, 19);
            
            CipherS Cipher_1 = Ic.ListS[S];
            CipherSI Cipher_2 = Ic.ListSI[SI];
            CipherSI Cipher_3 = Ic.ListSI[SI>10?SI-1:SI+1];

            //1st Encode
            EncodedMessage = Cipher_1.Encode(Message);
            //2nd Encode
            EncodedMessage = Cipher_2.Encode(EncodedMessage, Helpers.Randomize(5, 13));
            //3rd Encode
            EncodedMessage = Cipher_3.Encode(EncodedMessage, Helpers.Randomize(5, 13));
            //Create Keys
            PrivateKey = CreatePrivateKey(Cipher_1, Cipher_2, Cipher_3);
            PublicKey = CreatePublicKey(PrivateKey);

            // dokończ Public encode Key
            //TUTAJ SIE ROBI CZEK ENKODU JESZCZE!

            Ending e = new Ending(EncodedMessage,PrivateKey,PublicKey);

            //klucz publiczny a prywaty rózni sie tym ze publiczny jest zaszyfrowany a prywatny nie!
        }

        public static string CreatePrivateKey(CipherS s1, CipherSI s2, CipherSI s3) =>string.Format("{0}-{1}-{2}",s1.GetCode(),s2.GetCode(), s3.GetCode());
        public static string CreatePublicKey(string privateKey) => privateKey;

    }
}

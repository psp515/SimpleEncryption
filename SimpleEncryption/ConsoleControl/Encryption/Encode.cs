using EncryptionApp.Ciphers;
using EncryptionApp.Ciphers.C_Classes;
using SimpleEncryption.Files;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleEncryption.ConsoleControl.Encryption
{
    class Encode
    {
        string Message { get; set; }
        string PublicKey { get; set; }
        string PrivateKey { get; set; }
        public Encode() 
        { 
            Helpers.Error(); 
        }

        public Encode(string message)
        {
            Message = message;
        }
        public void EncoidingMessage()
        {
            InitializeCiphers Ic = new InitializeCiphers();

            int S = Helpers.Randomize(0, 7);
            int SI = Helpers.Randomize(0, 5);
            int SI2 = Helpers.Randomize(0, 5);

            CipherStrModel Cipher_1 = Ic.ListS[S];
            CipherStrIntModel Cipher_2 = Ic.ListSI[SI];
            CipherStrIntModel Cipher_3 = Ic.ListSI[SI > 2 ? SI - 1 : SI + 1];

            //1st Encode
            Message = Cipher_1.Encode(Message);
            //2nd Encode
            Message = Cipher_2.Encode(Message, Helpers.Randomize(6, 17));
            //3rd Encode
            Message = Cipher_3.Encode(Message, Helpers.Randomize(6, 17));
            //Create Keys
            PrivateKey = CreatePrivateKey(Cipher_1, Cipher_2, Cipher_3);
            PublicKey = CreatePublicKey(PrivateKey, Ic.ListS[(int)(S / 2)]);
            //CreateFiles
            FileManagement fileManagement = new FileManagement(Message,PrivateKey,PublicKey);
            fileManagement.CreateEncodedFile();
            

            End e = new End(PublicKey,PrivateKey,Message);
            e.EndEncode();
        }
        private string CreatePrivateKey(CipherStrModel s1, CipherStrIntModel s2, CipherStrIntModel s3) => string.Format("{0}-{1}-{2}", s1.GetCode(), s2.GetCode(), s3.GetCode());
        private string CreatePublicKey(string privateKey, CipherStrModel CSI)
        {
            privateKey = CSI.Encode(privateKey);
            return CSI.GetCode() + "-" + privateKey;
        }

    }
}

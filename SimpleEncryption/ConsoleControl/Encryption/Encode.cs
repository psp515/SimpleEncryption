using EncryptionApp.Ciphers;
using EncryptionApp.Ciphers.C_Classes;
using EncryptionApp.Ciphers.CipherStr;
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
            int S = Helpers.Randomize(1, 6);
            int S1 = Helpers.Randomize(1, 5);
            do
            {
                S1 = Helpers.Randomize(1, 5);
            }
            while (S == S1);
            int S2 = Helpers.Randomize(1, 2);

            CipherStrModel cipher_1 = new CipherStrModel();
            CipherStrModel cipher_2 = new CipherStrModel();
            CipherStrIntModel cipher_3 = new CipherStrIntModel();
            cipher_1 = FindCipherStr(S);
            cipher_2 = FindCipherStr(S1);
            cipher_3 = FindCipherStrInt(S2);


            Message = cipher_1.Encode(Message);
            Message = cipher_2.Encode(Message);
            Message = cipher_3.Encode(Message,(cipher_3.GetCode.ToString().Contains("F")? Helpers.Randomize(3, 6) : Helpers.Randomize(7, 19)));
            Message += ".";
            PrivateKey = CreatePrivateKey(cipher_1,cipher_2,cipher_3);
            PublicKey = CreatePublicKey(PrivateKey,FindCipherStr(S));

            FileManagement fileManagement = new FileManagement(Message,PrivateKey,PublicKey);
            fileManagement.CreateEncodedFile();

            End e = new End(PublicKey,PrivateKey,Message);
            e.EndEncode();
        }

        private CipherStrIntModel FindCipherStrInt(int s)
        {
            CipherStrIntModel cipherStrIntModel = new CipherStrIntModel();
            switch (s)
            {
                case 1:
                    CaesarVariation caesarVariation = new CaesarVariation();
                    cipherStrIntModel.Decode = caesarVariation.Decode;
                    cipherStrIntModel.Encode = caesarVariation.Encode;
                    cipherStrIntModel.GetCode = caesarVariation.GetCode;
                    return cipherStrIntModel;

                case 2:
                    RailFenceCipher caesarVariation1 = new RailFenceCipher();
                    cipherStrIntModel.Decode = caesarVariation1.Decode;
                    cipherStrIntModel.Encode = caesarVariation1.Encode;
                    cipherStrIntModel.GetCode = caesarVariation1.GetCode;
                    return cipherStrIntModel;

                default:
                    CaesarVariation caesarVariation2 = new CaesarVariation();
                    cipherStrIntModel.Decode = caesarVariation2.Decode;
                    cipherStrIntModel.Encode = caesarVariation2.Encode;
                    cipherStrIntModel.GetCode = caesarVariation2.GetCode;
                    return cipherStrIntModel;
            }
        }
        private CipherStrModel FindCipherStr(int s)
        {
            CipherStrModel cipherStrModel = new CipherStrModel();
            switch (s)
            {
                case 1:
                    Base64 base64 = new Base64();
                    cipherStrModel.Decode = base64.Decode;
                    cipherStrModel.Encode = base64.Encode;
                    cipherStrModel.GetCode = base64.GetCode;
                    return cipherStrModel;

                case 2:
                    Caesar caesar = new Caesar();
                    cipherStrModel.Decode = caesar.Decode;
                    cipherStrModel.Encode = caesar.Encode;
                    cipherStrModel.GetCode = caesar.GetCode;
                    return cipherStrModel;

                case 3:
                    ROT13 ROT13 = new ROT13();
                    cipherStrModel.Decode = ROT13.Decode;
                    cipherStrModel.Encode = ROT13.Encode;
                    cipherStrModel.GetCode = ROT13.GetCode;
                    return cipherStrModel;

                case 4:
                    ROT18 ROT18 = new ROT18();
                    cipherStrModel.Decode = ROT18.Decode;
                    cipherStrModel.Encode = ROT18.Encode;
                    cipherStrModel.GetCode = ROT18.GetCode;
                    return cipherStrModel;

                default:
                    Base64 base6 = new Base64();
                    cipherStrModel.Decode = base6.Decode;
                    cipherStrModel.Encode = base6.Encode;
                    cipherStrModel.GetCode = base6.GetCode;
                    return cipherStrModel;
            }
        }
        private string CreatePrivateKey(CipherStrModel s1, CipherStrModel s2, CipherStrIntModel s3) => string.Format("{0}-{1}-{2}", s1.GetCode(), s2.GetCode(), s3.GetCode());
        private string CreatePublicKey(string privateKey, CipherStrModel cipherStrModel)
        {
            privateKey = cipherStrModel.Encode(privateKey);
            return cipherStrModel.GetCode() + "-" + privateKey;
        }

    }
}

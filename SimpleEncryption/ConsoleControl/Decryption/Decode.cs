using EncryptionApp.Ciphers.C_Classes;
using EncryptionApp.Ciphers.CipherStr;
using SimpleEncryption.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleEncryption.ConsoleControl.Decryption
{
    public class Decode
    {
        public string Message { get; set; }
        public string EncodedMessage { get; set; }
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
        

        public Decode(string encodedMessage, string key)
        {
            EncodedMessage=DeleteDigit(encodedMessage);
            PrivateKey=SetKey(key);
            Process();
        }

        private string DeleteDigit(string encodedMessage)=> encodedMessage.Remove(encodedMessage.Length - 1);

        private string SetKey(string key)
        {
            if (key.Length > 11)
            {
                PublicKey = key;
                return DecodePublicKey(key);
            }
            else
                return key;
            
        }

        private string DecodePublicKey(string key)
        {
            string encodedPart = key.Remove(0, 4);
            string KeyCode = key[1].ToString() + key[2].ToString();
            int a = Convert.ToInt32(KeyCode);

            if (key[0] == 'F')
            {
                RailFenceCipher railFenceCipher = new RailFenceCipher();
                return railFenceCipher.Decode(encodedPart, a);
            }
            else
            {
                CaesarVariation caesarVariation = new CaesarVariation();
                return caesarVariation.Decode(encodedPart, a);
            }
        }

        public void Process()
        {
            string Last = "";
            string middle = "";
            string first = "";
            int a = 0;
            try
            {
                Last = PrivateKey[0].ToString();
                middle = PrivateKey[4].ToString();
                first = PrivateKey[8].ToString();
                a = Convert.ToInt32(PrivateKey[9].ToString() + PrivateKey[10].ToString());
            }
            catch 
            {
                Helpers.Error();
            }
            

            EncodedMessage = DecodeSI(a, first, EncodedMessage);
            EncodedMessage = DecodeS(middle, EncodedMessage);
            Message = DecodeS(Last, EncodedMessage);

            FileManagement fileManagement = new FileManagement(Message);
            fileManagement.CreateDeocdedFile();

            End e = new End(Message);
            e.EndDecode();
        }

        private string DecodeS(string code, string encodedMessage)
        {
            if (code == "B")
            {
                Base64 B = new Base64();
                return B.Decode(encodedMessage);
            }
            else if (code == "R")
            {
                ROT13 ROT = new ROT13();
                return ROT.Decode(encodedMessage);
            }
            else if(code == "T")
            {
                ROT18 ROT = new ROT18();
                return ROT.Decode(encodedMessage);
            }
            else if (code == "C")
            {
                Caesar c = new Caesar();
                return c.Decode(encodedMessage);
            }
            else 
            {
                return "Error";
            }
        }

        private string DecodeSI(int a, string code, string eMessage)
        {
            if (code == "F")
            {
                RailFenceCipher railFenceCipher = new RailFenceCipher();
                return railFenceCipher.Decode(eMessage, a);
            }
            if (code == "S")
            {
                RailFenceCipher railFenceCipher = new RailFenceCipher();
                return railFenceCipher.Decode(eMessage, a);
            }
            else if (code == "C")
            {
                CaesarVariation caesarVariation = new CaesarVariation();
                return caesarVariation.Decode(eMessage, a);
            }
            else
            {
                return "Error";
            }
        }
    }
}

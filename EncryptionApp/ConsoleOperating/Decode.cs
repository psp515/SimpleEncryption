using EncryptionApp.Ciphers;
using EncryptionApp.Ciphers.C_Classes;
using EncryptionApp.ConsoleOperating.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.ConsoleOperating
{
    public class Decode : IDE
    {
        public string Message { get; set; }
        public string EncodedMessage { get; set; }
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
        public bool IsPublicKey { get; set; }

        public Decode(string encodedMessage, string key)
        {
            EncodedMessage = encodedMessage;
            SetKey(key);
            Process();
        }

        private void SetKey(string key)
        {
            if (key.Length > 11)
            {
                IsPublicKey = true;
                PublicKey=key;
                PrivateKey=DecodePublicKey(key);
            }
            else
            {
                IsPublicKey = false;
                PrivateKey = key;
            }
        }

        private string DecodePublicKey(string key)
        {
            string encodedPart = key.Remove(0,4);
            string KeyCode = key[1].ToString() + key[2].ToString();
            int a = Convert.ToInt32(KeyCode);

            if(key[0]=='F')
            {
                FenceCipher fc = new FenceCipher();
                return fc.Decode(encodedPart, a);
            }
            else
            {
                CesarVariation cs = new CesarVariation();
                return cs.Decode(encodedPart, a);
            }
        }

        public void Process()
        {
           
            
            string Last=PrivateKey[0].ToString();
            string middle = PrivateKey[4].ToString();
            int b = Convert.ToInt32(PrivateKey[5].ToString() + PrivateKey[6].ToString());
            string first = PrivateKey[8].ToString();
            int a = Convert.ToInt32(PrivateKey[9].ToString() + PrivateKey[10].ToString());

            EncodedMessage=DecodeSI(a,first,EncodedMessage);
            EncodedMessage=DecodeSI(b, middle, EncodedMessage);
            Message=DecodeS(Last, EncodedMessage);

            Ending e = new Ending(Message);
        }

        private string DecodeS(string code, string encodedMessage)
        {
            if (code == "B")
            {
                Base64 B = new Base64();
                return B.Decode(encodedMessage);
            }
            else
            {
                Cesar c = new Cesar();
                return c.Decode(encodedMessage);
            }
        }

        private string DecodeSI(int a, string code,string eMessage)
        {
            if(code=="F")
            {
                FenceCipher fc = new FenceCipher();
                return fc.Decode(eMessage, a);
            }
            else
            {
                CesarVariation cv = new CesarVariation();
                return cv.Decode(eMessage, a);
            }
        }
    }
}

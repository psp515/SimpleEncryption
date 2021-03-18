using EncryptionApp.Ciphers.C_Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class Cesar : ICipherStandard
    {
        public string CipherCode { get; set; } = "C";


        public string Decode(string str)
        {
            char[] tab = str.ToCharArray();
            for (int i = 0; i < tab.Length; i++)
                 tab[i] = DecodeChar(tab[i]);
           
            return new string(tab);
        }

        public string Encode(string str)
        {
            char[] tab = str.ToCharArray();
            for (int i = 0; i < tab.Length; i++)
                  tab[i] = EncodeChar(tab[i]);
         
            return new string(tab);
        }

        public  char EncodeChar(char a)
        { 
            return 'a'; 
        }
        public char DecodeChar(char a) 
        { 
            return 'a'; 
        }
    }
}

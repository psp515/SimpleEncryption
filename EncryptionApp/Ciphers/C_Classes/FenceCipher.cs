using EncryptionApp.Ciphers.C_Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class FenceCipher : ICipherExtended
    {
        public string CipherCode { get; set; } = "F";

        public string Encode(string str, int n)
        {
            string[] tab = new string[n];
            int licznik = 1;
            int kie = 0;
            int rw = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char a = str[i];

                tab[rw] = string.Concat(tab[rw], a);
                if (rw == (n - 1) && kie == 0)
                {
                    kie = 1;
                    licznik = -1;
                }
                else if ((rw == 0 && i != 0) && kie == 1)
                {
                    kie = 0;
                    licznik = 1;
                }
                rw = rw + licznik;
            }
            string odp = "";
            for (int i = 0; i < tab.Length; i++)
                odp = string.Concat(odp, tab[i]);

            return odp;
        }

        public string Decode(string str, int n)
        {
            return null;
        }

        
    }
}

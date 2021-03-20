using EncryptionApp.Ciphers.C_Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class FenceCipher : ICipherExtended
    {
        public string CipherCode { get; set; } = "F";
        public int CipherCodeN { get; set; }

        public string Encode(string str, int n)
        {
            CipherCodeN = n;
            string[] tab = new string[n];
            int counter = 1;
            int direction = 0;
            int rw = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char a = str[i];

                tab[rw] = string.Concat(tab[rw], a);
                if (rw == (n - 1) && direction == 0)
                {
                    direction = 1;
                    counter = -1;
                }
                else if ((rw == 0 && i != 0) && direction == 1)
                {
                    direction = 0;
                    counter = 1;
                }
                rw = rw + counter;
            }
            string odp = "";
            for (int i = 0; i < tab.Length; i++)
                odp = string.Concat(odp, tab[i]);

            return odp;
        }
        public string Decode(string str, int n)
        {
            CipherCodeN = n;
            char[] tab = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                tab[i] = ' ';
            }
            //rzędy
            int row = 0;
            //1 bieg w dół -1 w bieg góre 
            int direction = 1;
            for (int i = 0; i < n; i++)
            {
                direction = 1;
                // litery w rzedzie
                for (int j = i; j < str.Length;)
                {
                    if (row >= str.Length)
                        break;

                    Console.WriteLine(j + "" + str[row]);
                    //przypisanie
                    tab[j] = str[row];
                    //okrslenie nastepnej pozycji
                    if (i == 0 || i == n - 1)
                    {
                        j += (n - 1) * 2;
                    }
                    else if (direction == 1 && (i != 0 && i != n - 1))
                    {
                        direction = -1;
                        j += (n - 1 - i) * 2;
                    }
                    else if (direction == -1 && (i != 0 && i != n - 1))
                    {
                        direction = 1;
                        j += i * 2;
                    }
                    row++;
                }
                if (row >= str.Length)
                    break;
            }
            return new string(tab);
        }

        public string GetCode() => CipherCode + CipherCodeN.ToString("D2");
    }
}

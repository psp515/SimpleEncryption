
using EncryptionApp.Ciphers.CiphersStrInt;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public class RailFenceCipher : CipherStrIntClass
    { 
        protected override string CipherCode { get; set; } = "F";
        protected override int CipherCodeN { get; set; }
        
        public override string Encode(string message, int key)
        {
            CipherCodeN = key;
            string[] tab = new string[key];
            int counter = 1;
            int direction = 0;
            int rw = 0;
            for (int i = 0; i < message.Length; i++)
            {
                char a = message[i];

                tab[rw] = string.Concat(tab[rw], a);
                if (rw == (key - 1) && direction == 0)
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
        public override string Decode(string message, int key)
        {
            CipherCodeN = key;
            char[] tab = new char[message.Length];
            for (int i = 0; i < message.Length; i++)
            {
                tab[i] = ' ';
            }
            int row = 0;
            int direction = 1;
            for (int i = 0; i < key; i++)
            {
                direction = 1;
                for (int j = i; j < message.Length;)
                {
                    if (row >= message.Length)
                        break;
                    tab[j] = message[row];
                    if (i == 0 || i == key - 1)
                    {
                        j += (key - 1) * 2;
                    }
                    else if (direction == 1 && (i != 0 && i != key - 1))
                    {
                        direction = -1;
                        j += (key - 1 - i) * 2;
                    }
                    else if (direction == -1 && (i != 0 && i != key - 1))
                    {
                        direction = 1;
                        j += i * 2;
                    }
                    row++;
                }
                if (row >= message.Length)
                    break;
            }
            return new string(tab);
        }
    }
}

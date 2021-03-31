
using EncryptionApp.Ciphers.CiphersStrInt;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public class Scytale : CipherStrIntClass
    {
        protected override string CipherCode { get; set; } = "S";
        protected override int CipherCodeN { get; set; }

        public override string Encode(string message, int key)
        {
            CipherCodeN = key;
            int n = 0;
            if (message.Length % key == 0)
                n = (int)(message.Length / key);
            else
                n = (int)1 + (message.Length / key);

            string[] encodedComponent = new string[n];
            int actn = 0;

            for (int i = 0; i < key; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (actn < message.Length)
                        encodedComponent[j] += message[actn];
                    else
                        encodedComponent[j] = encodedComponent[j] + " ";
                    actn++;
                }
            }
            return String.Join("", encodedComponent);
        }
        public override string Decode(string message, int key)
        {
            CipherCodeN = key;
            string[] decodedComponent = new string[key];
            int j = 0;

            for (int i = 0; i < message.Length; i++)
            {
                decodedComponent[j] += message[i];
                if (j < key - 1)
                    j++;
                else
                    j = 0;
            }
            return String.Join("", decodedComponent).Trim();
        }
    }
}

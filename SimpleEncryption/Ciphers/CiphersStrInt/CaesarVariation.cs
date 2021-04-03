using System;
using System.Collections.Generic;
using System.Text;

using EncryptionApp.Ciphers.CiphersStrInt;

namespace EncryptionApp.Ciphers.C_Classes
{
    public class CaesarVariation :  CipherStrIntClass
    {
        protected override string CipherCode { get; set; } = "C";
        protected override int CipherCodeN { get; set; }

        public override string Decode(string message, int key)
        {
            CipherCodeN = key;
            char[] tab = message.ToCharArray();
            for (int i = 0; i < tab.Length; i++)
                tab[i] = DecodeChar(tab[i], key);

            return new string(tab);
        }
        public override string Encode(string message, int key)
        {
            CipherCodeN = key;
            char[] tab = message.ToCharArray();
            for (int i = 0; i < tab.Length; i++)
                tab[i] = EncodeChar(tab[i], key);

            return new string(tab);
        }

        private char EncodeChar(char a, int n)
        {
            if (Char.IsUpper(a))
            {
                a = (char)(a + n);
                if (a > 'Z')
                    return (char)(a - 26);
                else if (a < 'A')
                    return (char)(a + 26);
                else
                    return a;
            }
            else if (Char.IsLower(a))
            {
                a = (char)(a + n);
                if (a > 'z')
                    return (char)(a - 26);
                else if (a < 'a')
                    return (char)(a + 26);
                else
                    return a;
            }
            else if (Char.IsDigit(a))
            {
                a = (char)(a + 5);
                if (a > '9')
                    return (char)(a - 10);
                else if (a < '0')
                    return (char)(a + 10);
                else
                    return a;
            }
            else
                return a;
        }
        private char DecodeChar(char a, int n)
        {
            if (Char.IsUpper(a))
            {
                a = (char)(a - n);
                if (a > 'Z')
                    return (char)(a - 26);
                else if (a < 'A')
                    return (char)(a + 26);
                else
                    return a;
            }
            else if (Char.IsLower(a))
            {
                a = (char)(a - n);
                if (a > 'z')
                    return (char)(a - 26);
                else if (a < 'a')
                    return (char)(a + 26);
                else
                    return a;
            }
            else if (Char.IsDigit(a))
            {
                a = (char)(a - 5);
                if (a > '9')
                    return (char)(a - 10);
                else if (a < '0')
                    return (char)(a + 10);
                else
                    return a;
            }
            else
                return a;
        }
    }
}

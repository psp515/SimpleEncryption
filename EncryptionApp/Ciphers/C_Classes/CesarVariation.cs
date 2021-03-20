using System;
using System.Collections.Generic;
using System.Text;
using EncryptionApp.Ciphers.C_Helpers;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class CesarVariation :  ICipherExtended
    {
        public string CipherCode { get; set; } = "C";
        public int CipherCodeN { get; set; }

        public string Decode(string str, int shift)
        {
            CipherCodeN = shift;
            char[] tab = str.ToCharArray();
            for (int i = 0; i < tab.Length; i++)
                tab[i] = DecodeChar(tab[i], shift);

            return new string(tab);
        }
        public string Encode(string str, int shift)
        {
            CipherCodeN = shift;
            char[] tab = str.ToCharArray();
            for (int i = 0; i < tab.Length; i++)
                tab[i] = EncodeChar(tab[i], shift);

            return new string(tab);
        }

        public char EncodeChar(char a, int n)
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
        public char DecodeChar(char a, int n)
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

        public string GetCode() => CipherCode + CipherCodeN.ToString("D2");
    }
}

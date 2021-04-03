using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.CipherStr
{
    public class ROT13 : CipherStrClass
    {
        protected override string CipherCode { get; set; } = "R13";

        public override string Decode(string message)
        {
            char[] tab = message.ToCharArray();
            for (int i = 0; i < tab.Length; i++)
                tab[i] = DecodeChar(tab[i]);

            return new string(tab);
        }
        public override string Encode(string message)
        {
            char[] tab = message.ToCharArray();
            for (int i = 0; i < tab.Length; i++)
                tab[i] = EncodeChar(tab[i]);

            return new string(tab);
        }

        private char EncodeChar(char a)
        {
            if (Char.IsUpper(a))
            {
                a = (char)(a + 13);
                if (a > 'Z')
                    return (char)(a - 26);
                else if (a < 'A')
                    return (char)(a + 26);
                else
                    return a;
            }
            else if (Char.IsLower(a))
            {
                a = (char)(a + 13);
                if (a > 'z')
                    return (char)(a - 26);
                else if (a < 'a')
                    return (char)(a + 26);
                else
                    return a;
            }
            else
                return a;
        }
        private char DecodeChar(char a)
        {
            if (Char.IsUpper(a))
            {
                a = (char)(a - 13);
                if (a > 'Z')
                    return (char)(a - 26);
                else if (a < 'A')
                    return (char)(a + 26);
                else
                    return a;
            }
            else if (Char.IsLower(a))
            {
                a = (char)(a - 13);
                if (a > 'z')
                    return (char)(a - 26);
                else if (a < 'a')
                    return (char)(a + 26);
                else
                    return a;
            }
            else
                return a;
        }
    }
}

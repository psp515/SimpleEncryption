using EncryptionApp.Ciphers.C_Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class FenceCipher : ICipherCode, ICipherExtended
    {
        public int CipherCodeN { get; set; }
        public string CipherCode { get; set; } = "F";
        public string GetCode() => CipherCode + CipherCodeN.ToString();

        public string Decode(string str, int n)
        {
            throw new NotImplementedException();
        }

        public string Encode(string str, int n)
        {
            throw new NotImplementedException();
        }

        
    }
}

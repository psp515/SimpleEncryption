using EncryptionApp.Ciphers.C_Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class Condi : ICipherMax
    {
        public string CipherCode { get; set; } = "Co";
        public string Key { get; set; }
        public int CipherCodeN { get; set; }
        public string GetCode() =>CipherCode+Key+CipherCodeN.ToString();

        public string Encode(string str, string key, int n)
        {
            throw new NotImplementedException();
        }

        public string Decode(string str, string key, int n)
        {
            throw new NotImplementedException();
        }
    }
}

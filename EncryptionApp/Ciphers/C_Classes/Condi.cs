using EncryptionApp.Ciphers.C_Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class Condi : ICipherCode, ICipherMax
    {
        public string CipherCode { get; set; } = "Co";
        public string Key { get; set; }
        public int CipherCodeN { get; set; }
        public string GetCode() =>CipherCode+Key+CipherCodeN.ToString();

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

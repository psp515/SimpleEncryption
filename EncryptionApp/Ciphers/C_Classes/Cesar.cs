using EncryptionApp.Ciphers.C_Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class Cesar : ICipherCode, ICipherStandard
    {
        public string CipherCode { get; set; } = "C";
        public string GetCode() => CipherCode;

        public string Decode(string str)
        {
            throw new NotImplementedException();
        }

        public string Encode(string str)
        {
            throw new NotImplementedException();
        }

      
    }
}

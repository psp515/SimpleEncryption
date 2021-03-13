using EncryptionApp.Ciphers.C_Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class Base91 : ICipherCode, ICipherStandard
    {
        public string CipherCode { get; set; } = "B91";
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

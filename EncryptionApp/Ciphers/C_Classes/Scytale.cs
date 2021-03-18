using EncryptionApp.Ciphers.C_Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class Scytale : ICipherExtended
    {
        public string CipherCode { get; set; } = "S";
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

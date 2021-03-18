using System;
using System.Collections.Generic;
using System.Text;
using EncryptionApp.Ciphers.C_Helpers;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class CesarVariation :  ICipherExtended
    {
        public string CipherCode { get; set; } = "C";

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

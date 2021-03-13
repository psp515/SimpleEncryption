using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Helpers
{
    interface ICipherExtended
    {
        public int CipherCodeN { get; set; }
        public string Encode(string str,int n);
        public string Decode(string str,int n);
    }
}

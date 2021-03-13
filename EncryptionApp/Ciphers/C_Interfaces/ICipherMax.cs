using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Helpers
{
    interface ICipherMax
    {
        public string Key { get; set; }
        public int CipherCodeN { get; set; }
        public string Encode(string str, int n);
        public string Decode(string str, int n);
    }
}

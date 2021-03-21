using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Helpers
{
    interface ICipherMax
    {
        public string GetCode();
        string CipherCode { get; set; }
        string Key { get; set; }
        int CipherCodeN { get; set; }
        public string Encode(string str,string key, int n);
        public string Decode(string str, string key, int n);
    }
}

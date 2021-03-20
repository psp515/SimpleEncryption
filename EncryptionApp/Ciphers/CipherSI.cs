using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public class CipherSI
    {
        public Func<string> GetCode { get; set; }
        public bool IsUsed { get; set; }
        public string Code { get; set; }
        public Func<string,int, string> Encode { get; set; }
        public Func<string,int, string> Decode { get; set; }
    }
}

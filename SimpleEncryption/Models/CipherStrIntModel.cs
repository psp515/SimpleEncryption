using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public class CipherStrIntModel
    {
        public Func<string> GetCode { get; set; }
        public Func<string,int, string> Encode { get; set; }
        public Func<string,int, string> Decode { get; set; }
    }
}

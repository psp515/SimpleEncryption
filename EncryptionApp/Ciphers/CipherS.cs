using EncryptionApp.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public class CipherS
    {
        public bool IsUsed { get; set; }
        public string Code { get; set; }
        public Func<string,string> Encode { get; set; }
        public Func<string, string> Decode { get; set; }

    }
}

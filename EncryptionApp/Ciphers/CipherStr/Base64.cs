
using EncryptionApp.Ciphers.CipherStr;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public class Base64 : CipherStrClass
    {
        protected override string CipherCode { get; set; } = "B64";

        public override string Decode(string message) => System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(message));
        public override string Encode(string message) => System.Convert.ToBase64String(Encoding.UTF8.GetBytes(message));
    }
}

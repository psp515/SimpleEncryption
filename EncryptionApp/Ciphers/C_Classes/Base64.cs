using EncryptionApp.Ciphers.C_Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Classes
{
    public sealed class Base64 : ICipherStandard
    {
        public string CipherCode { get; set; } = "B64";

        public string Decode(string str) => System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(str));
        public string Encode(string str) => System.Convert.ToBase64String(Encoding.UTF8.GetBytes(str));

        public string GetCode() => CipherCode;
    }
}

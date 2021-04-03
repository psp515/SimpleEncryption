using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.CiphersStrInt
{
    public abstract class CipherStrIntClass
    {
        protected virtual string CipherCode { get; set; } = "IsNotSet";
        protected virtual int CipherCodeN { get; set; }

        public string GetCode() => CipherCode + CipherCodeN.ToString("D2");
        public virtual string Encode(string message, int key) => message;
        public virtual string Decode(string message, int key) => message;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.CipherStr
{
    public abstract class CipherStrClass
    {
        protected virtual string CipherCode { get; set; } = "IsNotSet";
        public string GetCode() => CipherCode;

        public virtual string Encode(string message) => message;
        public virtual string Decode(string message) => message;
    }
}

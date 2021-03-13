using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Helpers
{
    interface ICipherCode
    {
        public string CipherCode { get; set; }
        public string GetCode();
    }
}

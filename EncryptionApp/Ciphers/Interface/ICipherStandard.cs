﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Helpers
{
    interface ICipherStandard
    {
        public string CipherCode { get; set; }
        public string Encode(string str);
        public string Decode(string str);
    }
}
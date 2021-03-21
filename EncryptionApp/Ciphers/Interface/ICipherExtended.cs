﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers.C_Helpers
{
    interface ICipherExtended
    {
        public string GetCode();
        int CipherCodeN { get; set; }
        string CipherCode { get; set; }
        public string Encode(string str,int n);
        public string Decode(string str,int n);
    }
}

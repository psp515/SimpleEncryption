using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using EncryptionApp.Ciphers.C_Classes;
using EncryptionApp.ConsoleOperating;
using EncryptionApp.ConsoleOperating.Interface;
using EncryptionApp.Helpers;

namespace EncryptionApp.ConsoleVisualAspects
{
    public class Starting 
    {
        public string Message { get; set; }
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }

        internal void StartingEncode()
        {
            Encode e = new Encode(Helpers.Helpers.GetString("Please, write message now:"));
            e.Process();
        }
        internal void StartingDecode()
        {
            Decode d = new Decode(Helpers.Helpers.GetString("Please, write message now:"), Helpers.Helpers.GetString("Please copy the code here:"));
        }
        

    }
}

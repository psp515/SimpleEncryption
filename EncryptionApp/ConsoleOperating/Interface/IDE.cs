using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.ConsoleOperating.Interface
{
    interface IDE
    {
        public void Process();
        public string Message { get; set; }
        public string EncodedMessage { get; set; }
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
    }
}

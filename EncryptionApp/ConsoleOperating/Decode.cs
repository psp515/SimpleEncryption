using EncryptionApp.ConsoleOperating.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.ConsoleOperating
{
    public class Decode : IDE
    {
        public string Message { get; set; }
        public string EncodedMessage { get; set; }
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }

        public Decode(string encodedMessage, string key)
        {
            EncodedMessage = encodedMessage;
            // public or private
            PublicKey = key;
        }

        public void Process()
        {
            throw new NotImplementedException();
        }
    }
}

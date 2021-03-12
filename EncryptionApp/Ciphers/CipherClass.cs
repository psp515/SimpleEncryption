using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers
{
    public interface CipherClass
    {
       
        public virtual string Encode(string A) { return A; }
        public virtual string Decode(string A) { return A; }
        

    }
}

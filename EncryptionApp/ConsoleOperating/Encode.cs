using EncryptionApp.Ciphers;
using EncryptionApp.Ciphers.C_Classes;
using EncryptionApp.ConsoleOperating.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Helpers
{
    public class Encode : IDE
    {
        public string Message { get; set; } = "abcde";
        public string FullCode { get; set; }
        bool[] tab;

        public Encode()
        {
            Cesar z = new Cesar();
            List<CipherS> c = new List<CipherS>();
            CipherS x = new CipherS();
            x.Encode = z.Encode;
            c.Add(x);

            Message=c[0].Encode(Message);
            Console.WriteLine(Message);
        }

        public Encode(string str)
        {
           Message = str;
           Process();
        }

        public void Process()
        {
            InitializeCiphers Ic = new InitializeCiphers();
            int S = Helpers.Randomize(0, 1);
            int SI = 0; //Helpers.Randomize(0, 1);

            Console.WriteLine(Ic.ListSI[SI].Encode(Message, 2));
            FullCode += Ic.ListSI[SI].Code;

            Console.WriteLine(FullCode);
           

        }

        
    }
}

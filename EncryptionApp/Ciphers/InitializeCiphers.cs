using EncryptionApp.Ciphers.C_Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers
{
    public class InitializeCiphers
    {
        public List<CipherSI> ListSI;
        List<CipherS> ListS;
        public InitializeCiphers()
        {

            Console.WriteLine("Init");
            Cesar C = new Cesar();
            Base64 B64 = new Base64();
            CesarVariation Cv = new CesarVariation();
            FenceCipher Fc = new FenceCipher();
            

            ListSI = new List<CipherSI>();

            CipherSI Fence = new CipherSI();
            Fence.Code = Fc.CipherCode;
            Fence.Encode = Fc.Encode;
            Fence.Decode = Fc.Decode;
            Fence.IsUsed = false;
            CipherSI cesarVariation = new CipherSI();
            cesarVariation.Code = Cv.CipherCode;
            cesarVariation.Decode = Cv.Decode;
            cesarVariation.Encode = Cv.Encode;
            cesarVariation.IsUsed = false;

            //ListSI.Add(cesarVariation);
            ListSI.Add(Fence);


            ListS = new List<CipherS>();

            CipherS Cesar= new CipherS();
            Cesar.Code = C.CipherCode;
            Cesar.Encode = C.Encode;
            Cesar.Decode = C.Decode;
            Cesar.IsUsed = false;
            CipherS B6 = new CipherS();
            B6.Code = B64.CipherCode;
            B6.Decode = B64.Decode;
            B6.Encode = B64.Encode;
            B6.IsUsed = false;

            ListS.Add(B6);
            ListS.Add(Cesar);
        }  
    }
}

﻿using EncryptionApp.Ciphers.C_Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers
{
    public class InitializeCiphers
    {
        public List<CipherSI> ListSI;
        public List<CipherS> ListS;
        public InitializeCiphers()
        {

            Cesar C = new Cesar();
            Base64 B64 = new Base64();
            CesarVariation Cv = new CesarVariation();
            FenceCipher Fc = new FenceCipher();
            

            ListSI = new List<CipherSI>();

            CipherSI Fence = new CipherSI();
            Fence.Encode = Fc.Encode;
            Fence.Decode = Fc.Decode;
            Fence.IsUsed = false;
            Fence.GetCode = Fc.GetCode;
            CipherSI cesarVariation = new CipherSI();
            cesarVariation.Decode = Cv.Decode;
            cesarVariation.Encode = Cv.Encode;
            cesarVariation.IsUsed = false;
            cesarVariation.GetCode = Cv.GetCode;

            for(int i =0;i<10;i++)
            {
                ListSI.Add(Fence);
                ListSI.Add(cesarVariation);
            }

            ListS = new List<CipherS>();

            CipherS Cesar= new CipherS();
            Cesar.GetCode = C.GetCode;
            Cesar.Encode = C.Encode;
            Cesar.Decode = C.Decode;
            Cesar.IsUsed = false;
            CipherS B6 = new CipherS();
            B6.GetCode = B64.GetCode;
            B6.Decode = B64.Decode;
            B6.Encode = B64.Encode;
            B6.IsUsed = false;

            for (int i = 0; i < 10; i++)
            {
                ListS.Add(B6);
                ListS.Add(Cesar);
            }
            
        }  
    }
}

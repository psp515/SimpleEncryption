using EncryptionApp.Ciphers.C_Classes;
using EncryptionApp.Ciphers.CipherStr;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionApp.Ciphers
{
    public class InitializeCiphers
    {
        public List<CipherStrIntModel> ListSI;
        public List<CipherStrModel> ListS;
        public InitializeCiphers()
        {
            //List Init
            ListSI = new List<CipherStrIntModel>();
            ListS = new List<CipherStrModel>();

            //CipherStr
            Caesar caesarModel = new Caesar();
            Base64 base64Model = new Base64();
            ROT13 ROT13Model = new ROT13();
            ROT18 ROT18Model = new ROT18();

            //CipherStrInt
            CaesarVariation caesarVariationModel = new CaesarVariation();
            RailFenceCipher fenceCipherModel = new RailFenceCipher();
            Scytale scytaleModel = new Scytale();

            //CiphersStrIntModel
            CipherStrIntModel fence = new CipherStrIntModel();
            fence.Encode = fenceCipherModel.Encode;
            fence.Decode = fenceCipherModel.Decode;
            fence.GetCode = fenceCipherModel.GetCode;
            CipherStrIntModel cesarVariation = new CipherStrIntModel();
            cesarVariation.Decode = caesarVariationModel.Decode;
            cesarVariation.Encode = caesarVariationModel.Encode;
            cesarVariation.GetCode = caesarVariationModel.GetCode;
            CipherStrIntModel scytale = new CipherStrIntModel();
            scytale.Decode = scytaleModel.Decode;
            scytale.Encode = scytaleModel.Encode;
            scytale.GetCode = scytaleModel.GetCode;

            //AddCiphersStrInt
            for(int i =0;i<2;i++)
            {
                ListSI.Add(fence);
                ListSI.Add(cesarVariation);
                ListSI.Add(scytale);
            }

            //CiphersStrModel
            CipherStrModel caesar = new CipherStrModel();
            caesar.GetCode = caesarModel.GetCode;
            caesar.Encode = caesarModel.Encode;
            caesar.Decode = caesarModel.Decode;
            CipherStrModel base64 = new CipherStrModel();
            base64.GetCode = base64Model.GetCode;
            base64.Decode = base64Model.Decode;
            base64.Encode = base64Model.Encode;
            CipherStrModel ROT13 = new CipherStrModel();
            ROT13.GetCode = ROT13Model.GetCode;
            ROT13.Encode = ROT13Model.Encode;
            ROT13.Decode = ROT13Model.Decode;
            CipherStrModel ROT18 = new CipherStrModel();
            ROT18.GetCode = ROT18Model.GetCode;
            ROT18.Encode = ROT18Model.Encode;
            ROT18.Decode = ROT18Model.Decode;

            //AddCiphersStr
            for(int i =0;i<2; i++)
            {
                ListS.Add(base64);
                ListS.Add(caesar);
                ListS.Add(ROT13);
                ListS.Add(ROT13);
            }
        }  
    }
}

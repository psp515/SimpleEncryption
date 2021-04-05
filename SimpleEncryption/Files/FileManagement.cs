using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimpleEncryption.Files
{
    public class FileManagement
    {
        public string Message { get; set; }
        public string PrivateKey { get; set; }
        public string PublicKey { get; set; }

        public FileManagement() 
        {
            DirectioriesManagement directioriesManagement = new DirectioriesManagement();
            directioriesManagement.CreateMainDirectories(false);
        }
        public FileManagement(string message)
        {
            DirectioriesManagement directioriesManagement = new DirectioriesManagement();
            directioriesManagement.CreateMainDirectories(false);

            Message = message;
        }
        public FileManagement(string message,string privateKey, string publicKey) 
        {
            DirectioriesManagement directioriesManagement = new DirectioriesManagement();
            directioriesManagement.CreateMainDirectories(false);

            Message = message;
            PrivateKey = privateKey;
            PublicKey = publicKey;
        }
        
        public void CreateDeocdedFile()
        {
            long s = DateTime.Now.Ticks;
            string fullText = string.Format("Your Encoded Message: \n{0}", Message);
            string fullFileName = Helpers.DirectoryPath + @"\Decoded\DecodedMessage" + s.ToString() + @".txt";

            CreateFile(fullFileName, fullText);
        }

        public void CreateEncodedFile()
        {
            long s = DateTime.Now.Ticks;
            string FullText = string.Format("Your private decode key: \n{0}\nYour public decode key: (not working right now) \n{1}\nYour Encoded Message: \n{2}\nFile created: {3}", PrivateKey, PublicKey, Message,DateTime.Now);
            string fullFileName = Helpers.DirectoryPath+ @"\Encoded\FullInfo" + s.ToString() + @".txt";
            string encodedFileName = Helpers.DirectoryPath + @"\Encoded\EncodedMessage" + s.ToString() + @".txt";

            CreateFile(encodedFileName.Trim(), Message);
            CreateFile(fullFileName.Trim(), FullText);
        }

        private void CreateFile(string fileName,string fileText)
        {
            try
            {
                if (File.Exists(fileName))
                    File.Delete(fileName);
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine(fileText);
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.ToString());

                Helpers.SpecificUnauthorizedException();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Helpers.Error();
            }
        }
        
        public string ReadFileToEncode(string fileName) => ReadFile(Helpers.DirectoryPath + @"\ToEncode\" + (fileName.Contains(".txt") ? fileName : fileName + ".txt"));
        public string ReadFileToDecode(string fileName) => ReadFile(Helpers.DirectoryPath + @"\ToDecode\" + (fileName.Contains(".txt") ? fileName : fileName + ".txt"));

        public string ReadFile(string fileName)
        {
            try
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadToEnd()) != null)
                    {
                        return s;
                    }
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Helpers.SpecificUnauthorizedException();
                return null;
            }
            catch (FileNotFoundException e)
            {
                return null;
            }
            catch (Exception e)
            {
                Helpers.Error();
                return null;
            }
            return null;
        }
    }
}


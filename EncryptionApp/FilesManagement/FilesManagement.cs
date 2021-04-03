using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EncryptionApp.FilesManagement
{
    public class FilesManagement
    {
        public string Message { get; set; }
        public string PrivateKey { get; set; }
        public string PublickKey { get; set; }
        public string DecodeFileName { get; set; }

        public FilesManagement() { }
        public FilesManagement(string decodeFileName)
        {
            DecodeFileName = decodeFileName;

            DirectoryManagement directoryManagement = new DirectoryManagement();
            directoryManagement.CreateMainDirectories();
        }
        public FilesManagement(string message, string privateKey, string publicKey)
        {
            Message = message;
            PrivateKey = privateKey;
            PublickKey = publicKey;

            DirectoryManagement directoryManagement = new DirectoryManagement();
            directoryManagement.CreateMainDirectories();
        }
        public void CreateFile()
        {
            long s = DateTime.Now.Ticks;
            CreateEncodedMainFile(@"C:\EncryptionApp\Encoded\FullFileInfo"+s.ToString()+".txt");
            CreateEncodedMessageFile(@"C:\EncryptionApp\Encoded\EncodedFile" + s.ToString() + ".txt");
        }

        private void CreateEncodedMessageFile(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                    File.Delete(fileName);
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine(Message);
                }
                Console.WriteLine("(File created at {0})", fileName);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                Helpers.Helpers.Error();
            }
        }
        private void CreateEncodedMainFile(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                    File.Delete(fileName);
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine("New file created: {0}", DateTime.Now.ToString());
                    sw.WriteLine(Helpers.Helpers.CreateEncodeOutput(Message,PrivateKey,PublickKey));
                }
                Console.WriteLine("(File created at {0})", fileName);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                Helpers.Helpers.Error();
            }
        }

        public string ReadDecodingFile(string fileName) => ReadFile(@"C:\EncryptionApp\Encoded\" + (fileName.Contains(".txt") ? "" : fileName + ".txt"));
        public string ReadEncodingFile(string fileName) => ReadFile(@"C:\EncryptionApp\Decoded\" + (fileName.Contains(".txt") ? "" : fileName + ".txt"));

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
            catch (FileNotFoundException e)
            {
                return "NIEMAPLIKU";
            }
            catch(Exception e)
            {
                return "NIEWIEM";
            }
            return "COŚJEBŁO";

        }
    }
}


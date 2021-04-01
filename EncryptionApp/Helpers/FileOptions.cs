using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EncryptionApp.Helpers
{
    public class FileOptions
    {
        public string EncodedMessage { get; set; }
        public string FileMessage { get; set; }
        public string FileName { get; set; } 
        public FileOptions() { }

        public FileOptions(string encodedMessage, string privateKey, string publicKey)
        {
            EncodedMessage = encodedMessage;
            FileMessage = Helpers.CreateEncodeOutput(encodedMessage, privateKey, publicKey);
        }
        public FileOptions(string fileMessage, string fileName)
        {
            FileMessage = fileMessage;
            FileName = fileName;
        }

        public void Create()
        {
            CreateDirectory();
            CreateEncodedMainFile(@"C:\EncryptionApp\EncodedMessageFullInfo.txt");
            CreateEncodedMessageFile(@"C:\EncryptionApp\EncodedMessage.txt");
        }

        private void CreateEncodedMessageFile(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                    File.Delete(fileName);
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine(EncodedMessage);
                }

                Console.WriteLine("(File created at {0})", fileName);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                Helpers.Error();
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
                    sw.WriteLine(FileMessage);
                }

                Console.WriteLine("(File created at {0})", fileName);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                Helpers.Error();
            }
        }

        private void CreateDirectory()
        {
            try
            {
                string directory = @"C:\EncryptionApp";
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Helpers.Error();
            }
        }

        public void CreateDirectoryMenu()
        {
            Console.Clear();
            CreateDirectory();
            Console.WriteLine(@"Directory created...  (C:\EncryptionApp)");
            Thread.Sleep(2500);
            Console.Clear();
            Program.Starting();
        }

       public void ReadFile()
       {
            string fileName = FileName;
            using (StreamReader sr = File.OpenText(fileName))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
       }
    }
}

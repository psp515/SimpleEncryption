using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace SimpleEncryption.Files
{
    public class DirectioriesManagement
    {
        public string MainPath { get; set; } = Helpers.DirectoryPath;
        public void CreateMainDirectories(bool announce)
        {
            if (announce)
                AnnounceCreation();
            CreateDirectory(Path.Combine(MainPath, @"\Encoded\"));
            CreateDirectory(Path.Combine(MainPath,@"\ToEncode\"));
            CreateDirectory(Path.Combine(MainPath, @"\Decoded\"));
            CreateDirectory(Path.Combine(MainPath, @"\ToDecode\"));
        }

        private void AnnounceCreation()
        {
            Console.Clear();
            Console.WriteLine("Main directories has been created at: \n"+MainPath);
            Thread.Sleep(2500);
        }

        private void CreateDirectory(string dir)
        {
            try
            {
                string directory = Directory.GetCurrentDirectory() + dir;
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Helpers.Error();
            }
        }
    }
}

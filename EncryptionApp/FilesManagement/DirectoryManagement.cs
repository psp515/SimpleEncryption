using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace EncryptionApp.FilesManagement
{
    public class DirectoryManagement
    {

        public void CreateMainDirectories()
        {
            CreateDirectory(@"\EncryptionApp");
            CreateDirectory(@"\EncryptionApp\Encoded");
            CreateDirectory(@"\EncryptionApp\Decoded");

            WriteInfo();
        }

        private void WriteInfo()
        {
            Console.Clear();
            Console.WriteLine("Directories has been  created. Moving to Main Menu...");
            Thread.Sleep(2500);
            Console.Clear();
        }

        private void CreateDirectory(string dir)
        {
            try
            {
                string directory = @"C:"+dir;
                if (!Directory.Exists(directory))
                    Directory.CreateDirectory(directory);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Helpers.Helpers.Error();
            }
        }
    }
}

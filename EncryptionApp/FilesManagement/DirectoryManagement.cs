using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EncryptionApp.FilesManagement
{
    public class DirectoryManagement
    {

        public void CreateMainDirectories()
        {
            CreateDirectory(@"\EncryptionApp");
            CreateDirectory(@"\EncryptionApp\Encoded");
            CreateDirectory(@"\EncryptionApp\Decoded");
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
